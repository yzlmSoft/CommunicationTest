using Communication.Bus;
using Communication.Bus.PhysicalPort;
using CommunicationTest.Config.AutoReply;
using CommunicationTest.Config.Connection;
using CommunicationTest.Config.Parser;
using CommunicationTest.Config.SendList;
using CommunicationTest.UC;
using Microsoft.Data.Sqlite;
using Microsoft.Win32;
using Parser;
using Parser.Interfaces;
using Parser.Parsers;
using System.Data;
using System.IO.Ports;
using System.Net;
using System.Text;
using TopPortLib;
using Utils;

namespace CommunicationTest
{
    public partial class Main : Form
    {
        CancellationTokenSource? _closeCts;
        Task? _task;

        bool isConnect = false;
        TabPage? tabPage;
        /// <summary>
        /// 所选行ID
        /// </summary>
        int? _selectID;
        int _maxID = -1;

        public Main()
        {
            InitializeComponent();
        }

        private async void Main_LoadAsync(object sender, EventArgs e)
        {
            var Start = new Start();
            Start.ShowDialog();
            if (await Global.ConnectionConfig!.AutoConnectAsync())
            {
                btnConnect.PerformClick();
            }
            cbAutoConnect.Checked = await Global.ConnectionConfig.AutoConnectAsync();
            cbAutoReply.Checked = await Global.AutoReplyConfig!.AutoReplyAsync();
            await RefreshStatus();
            await RefreshDataGridView();
        }

        private async Task RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            var sendList = await Global.SendListConfig!.GetAsync();
            if (sendList.Count > 0)
            {
                sendList.Sort((x, y) => x.ID.CompareTo(y.ID));
                _maxID = sendList[^1].ID;
            }
            foreach (var item in sendList)
            {
                var row = new DataGridViewRow
                {
                    Tag = item
                };
                var Used = new DataGridViewCheckBoxCell
                {
                    Value = item.Used
                };
                row.Cells.Add(Used);
                var CName = new DataGridViewTextBoxCell
                {
                    Value = item.CName
                };
                row.Cells.Add(CName);
                var SendType = new DataGridViewComboBoxCell();
                var dt = new DataTable();
                dt.Columns.Add(new DataColumn("SendType"));
                Enum.GetNames(typeof(SendType)).ToList().ForEach(x => dt.Rows.Add(x));
                SendType.DataSource = dt;
                SendType.DisplayMember = "SendType";
                SendType.Value = item.SendType.ToString();
                row.Cells.Add(SendType);
                var Cmd = new DataGridViewTextBoxCell
                {
                    Value = item.SendType switch
                    {
                        Config.SendList.SendType.Hex => StringByteUtils.BytesToString(item.Cmd),
                        Config.SendList.SendType.ASCII => Encoding.ASCII.GetString(item.Cmd),
                        Config.SendList.SendType.UTF8 => Encoding.UTF8.GetString(item.Cmd),
                        Config.SendList.SendType.GB2312 => Encoding.GetEncoding(item.SendType.ToString()).GetString(item.Cmd),
                        _ => StringByteUtils.BytesToString(item.Cmd),
                    }
                };
                row.Cells.Add(Cmd);
                var r = new DataGridViewCheckBoxCell
                {
                    Value = item.HaveR
                };
                row.Cells.Add(r);
                var n = new DataGridViewCheckBoxCell
                {
                    Value = item.HaveN
                };
                row.Cells.Add(n);
                var CrcType = new DataGridViewComboBoxCell();
                var cdt = new DataTable();
                cdt.Columns.Add(new DataColumn("CrcType"));
                Enum.GetNames(typeof(CrcType)).ToList().ForEach(x => cdt.Rows.Add(x));
                CrcType.DataSource = cdt;
                CrcType.DisplayMember = "CrcType";
                CrcType.Value = item.CrcType.ToString();
                row.Cells.Add(CrcType);
                dataGridView1.Rows.Add(row);
            }
        }

        private async Task RefreshStatus()
        {
            var connectionConfig = await Global.ConnectionConfig!.GetAsync();
            var parserConfig = await Global.ParserConfig!.GetAsync();
            Dictionary<string, string> cconfig = connectionConfig.Item2;

            switch (connectionConfig.Item1)
            {
                case ConnectionType.SerialPort:
                    btnConnect.Text = isConnect ? "关闭串口" : "打开串口";
                    toolStripStatusLabel1.Text = $"当前 [连接方式:{connectionConfig.Item1}] [分包方式:{parserConfig.Item1}] [连接状态:{isConnect}][串口名:{cconfig["PortName"]}][波特率:{cconfig["BaudRate"]}][数据位:{cconfig["DataBits"]}][停止位:{cconfig["StopBits"]}][校验位:{cconfig["Parity"]}]";
                    break;
                case ConnectionType.TCPServer:
                    btnConnect.Text = isConnect ? "停止监听" : "监听";
                    toolStripStatusLabel1.Text = $"当前 [连接方式:{connectionConfig.Item1}] [分包方式:{parserConfig.Item1}] [监听状态:{isConnect}][监听本地:{cconfig["TCPServerIP"]}:{cconfig["TCPServerPort"]}]";
                    break;
                case ConnectionType.TCPClient:
                    btnConnect.Text = isConnect ? "断开连接" : "连接";
                    toolStripStatusLabel1.Text = $"当前 [连接方式:{connectionConfig.Item1}] [分包方式:{parserConfig.Item1}] [连接状态:{isConnect}][连接远端:{cconfig["TCPClientIP"]}:{cconfig["TCPClientPort"]}]";
                    break;
                default:
                    break;
            }
            通讯配置ToolStripMenuItem.Enabled = !isConnect;
            分包规则ToolStripMenuItem.Enabled = !isConnect;
            导入配置ToolStripMenuItem.Enabled = !isConnect;
            导出配置ToolStripMenuItem.Enabled = !isConnect;
        }

        private async void BtnConnect_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                btnConnect.Enabled = false;
                var connectionConfig = await Global.ConnectionConfig!.GetAsync();
                if (!isConnect)
                {
                    Global.Parser = await NewParser();

                    switch (connectionConfig.Item1)
                    {
                        case ConnectionType.SerialPort:
                            {
                                var portName = connectionConfig.Item2["PortName"];
                                var baudRate = int.Parse(connectionConfig.Item2["BaudRate"]);
                                var parity = (Parity)Enum.Parse(typeof(Parity), connectionConfig.Item2["Parity"]);
                                var dataBits = int.Parse(connectionConfig.Item2["DataBits"]);
                                var stopBits = (StopBits)Enum.Parse(typeof(StopBits), connectionConfig.Item2["StopBits"]);
                                var serialPort = new Communication.Bus.PhysicalPort.SerialPort(portName, baudRate, parity, dataBits, stopBits)
                                {
                                    DtrEnable = bool.Parse(connectionConfig.Item2["Dtr"]),
                                    RtsEnable = bool.Parse(connectionConfig.Item2["Rts"])
                                };
                                Global.TopPort = new TopPort(serialPort, Global.Parser);

                                var dr = tabControl1.TabPages.ContainsKey(portName) ? (DataReceive)tabControl1.TabPages[portName]!.Controls[0] : new DataReceive();
                                Global.TopPort.OnConnect += async () => await TopPort_OnConnect(dr, portName);
                                Global.TopPort.OnDisconnect += async () => await TopPort_OnDisconnect(dr);
                                Global.TopPort.OnSentData += async data =>
                                {
                                    _ = Task.Run(async () =>
                                    {
                                        await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
                                        {
                                            await dr!.AddDataAsync(data, true);
                                        })), EndInvoke);
                                    });
                                    await Task.CompletedTask;
                                };

                                Global.TopPort.OnReceiveParsedData += async data => await TopPort_OnReceiveParsedData(data, dr);
                                await Global.TopPort.OpenAsync();
                            }
                            break;
                        case ConnectionType.TCPServer:
                            {
                                var TCPServerIP = connectionConfig.Item2["TCPServerIP"] == "Any" ? IPAddress.Any.ToString() : connectionConfig.Item2["TCPServerIP"];
                                var TCPServerPort = int.Parse(connectionConfig.Item2["TCPServerPort"]);
                                Global.TcpServer = new TopPort_Server(new TcpServer(TCPServerIP, TCPServerPort), NewParser);
                                Global.TcpServer.OnSentData += async (data, clientId) =>
                                {
                                    _ = Task.Run(async () =>
                                    {
                                        await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
                                        {
                                            if (!Global.DataReceives.TryGetValue(clientId, out var dr)) return;
                                            await dr.AddDataAsync(data, true);
                                        })), EndInvoke);
                                    });
                                    await Task.CompletedTask;
                                };
                                Global.TcpServer.OnReceiveParsedData += TcpServer_OnReceiveParsedData;
                                Global.TcpServer.OnClientConnect += TcpServer_OnClientConnect;
                                Global.TcpServer.OnClientDisconnect += TcpServer_OnClientDisconnect;
                                await Global.TcpServer.OpenAsync();
                            }
                            break;
                        case ConnectionType.TCPClient:
                            {
                                var TCPClientIP = connectionConfig.Item2["TCPClientIP"] == "Any" ? IPAddress.Any.ToString() : connectionConfig.Item2["TCPClientIP"];
                                var TCPClientPort = int.Parse(connectionConfig.Item2["TCPClientPort"]);
                                Global.TopPort = new TopPort(new TcpClient(TCPClientIP, TCPClientPort), Global.Parser);
                                var dr = tabControl1.TabPages.ContainsKey($"{TCPClientIP}:{TCPClientPort}") ? (DataReceive)tabControl1.TabPages[$"{TCPClientIP}:{TCPClientPort}"]!.Controls[0] : new DataReceive();
                                Global.TopPort.OnConnect += async () => await TopPort_OnConnect(dr, $"{TCPClientIP}:{TCPClientPort}");
                                Global.TopPort.OnDisconnect += async () => await TopPort_OnDisconnect(dr);
                                Global.TopPort.OnSentData += async data =>
                                {
                                    _ = Task.Run(async () =>
                                    {
                                        await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
                                        {
                                            await dr!.AddDataAsync(data, true);
                                        })), EndInvoke);
                                    });
                                    await Task.CompletedTask;
                                };
                                Global.TopPort.OnReceiveParsedData += async data => await TopPort_OnReceiveParsedData(data, dr);
                                await Global.TopPort.OpenAsync();
                            }
                            break;
                        default:
                            break;
                    }
                    isConnect = true;
                }
                else
                {
                    switch (connectionConfig.Item1)
                    {
                        case ConnectionType.TCPServer:
                            await Global.TcpServer!.CloseAsync();
                            break;
                        case ConnectionType.SerialPort:
                        case ConnectionType.TCPClient:
                            await Global.TopPort!.CloseAsync();
                            var str = tabPage!.Text;
                            if (str.Contains("掉线尝试重连"))
                            {
                                tabPage.Text = str.Replace(" 掉线尝试重连", string.Empty);
                            }
                            tabPage.Text += " 测试关闭";
                            CloseTabPage();
                            break;
                        default:
                            break;
                    }
                    isConnect = false;
                }
                await RefreshStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败 " + ex.Message);
                await RefreshStatus();
            }
            finally
            {
                btnConnect.Enabled = true;
            }
        }

        private async Task TopPort_OnDisconnect(DataReceive dr)
        {
            isConnect = false;
            await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
            {
                if (!dr.Parent!.Text.Contains("测试关闭"))
                {
                    dr.Parent.Text += " 掉线尝试重连";
                    btnConnect.Enabled = false;
                }
                await RefreshStatus();
            })), EndInvoke);
        }

        private async Task TopPort_OnConnect(DataReceive dr, string name)
        {
            isConnect = true;
            await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
            {
                if (!tabControl1.TabPages.ContainsKey(name))
                {
                    dr.Dock = DockStyle.Fill;
                    tabPage = new TabPage(name)
                    {
                        Name = name
                    };
                    tabPage.Controls.Add(dr);
                    tabControl1.TabPages.Add(tabPage);
                    tabControl1.SelectedTab = tabPage;
                }
                else
                {
                    tabControl1.TabPages[name]!.Text = name;
                    tabControl1.SelectedTab = tabControl1.TabPages[name];
                }
                var str = dr.Parent!.Text;
                if (str.Contains("掉线尝试重连"))
                {
                    dr.Parent.Text = str.Replace(" 掉线尝试重连", string.Empty);
                }
                btnConnect.Enabled = true;
                await RefreshStatus();
            })), EndInvoke);
        }

        private static async Task<IParser> NewParser()
        {
            var parserConfig = await Global.ParserConfig!.GetAsync();

            switch (parserConfig.Item1)
            {
                case ParserType.None:
                    return new NoParser();
                case ParserType.TimeParser:
                    return new TimeParser(int.Parse(parserConfig.Item2["Time"]));
                case ParserType.HeadLengthParser:
                    {

                        var Head = parserConfig.Item2["HLHead"];
                        if (Head == "")
                            return new HeadLengthParser(GetDataLength);
                        else
                            return new HeadLengthParser(StringByteUtils.StringToBytes(Head), GetDataLength);
                    }
                case ParserType.HeadFootParser:
                    return new HeadFootParser(StringByteUtils.StringToBytes(parserConfig.Item2["HFHead"]), StringByteUtils.StringToBytes(parserConfig.Item2["HFFoot"]));
                case ParserType.FootParser:
                    return new FootParser(StringByteUtils.StringToBytes(parserConfig.Item2["FFoot"]));
                default:
                    return new NoParser();
            }
        }

        private static async Task<GetDataLengthRsp> GetDataLength(byte[] data)
        {
            var parserConfig = await Global.ParserConfig!.GetAsync();
            var head = StringByteUtils.StringToBytes(parserConfig.Item2["HLHead"]);
            int Length = 0;
            switch ((HLType)Enum.Parse(typeof(HLType), parserConfig.Item2["HLType"]))
            {
                case HLType.头后FloatL:
                    if (data.Length < head.Length + 4) return new GetDataLengthRsp() { StateCode = Parser.StateCode.LengthNotEnough };
                    Length = (int)StringByteUtils.ToSingle(data, head.Length + 0);
                    break;
                case HLType.头后FloatH:
                    if (data.Length < head.Length + 4) return new GetDataLengthRsp() { StateCode = Parser.StateCode.LengthNotEnough };
                    Length = (int)StringByteUtils.ToSingle(data, head.Length + 0, true);
                    break;
                case HLType.头后ShortL:
                    if (data.Length < head.Length + 2) return new GetDataLengthRsp() { StateCode = Parser.StateCode.LengthNotEnough };
                    Length = StringByteUtils.ToInt16(data, head.Length + 0);
                    break;
                case HLType.头后ShortH:
                    if (data.Length < head.Length + 2) return new GetDataLengthRsp() { StateCode = Parser.StateCode.LengthNotEnough };
                    Length = StringByteUtils.ToInt16(data, head.Length + 0, true);
                    break;
                case HLType.头后Int32L:
                    if (data.Length < head.Length + 4) return new GetDataLengthRsp() { StateCode = Parser.StateCode.LengthNotEnough };
                    Length = StringByteUtils.ToInt32(data, head.Length + 0);
                    break;
                case HLType.头后Int32H:
                    if (data.Length < head.Length + 4) return new GetDataLengthRsp() { StateCode = Parser.StateCode.LengthNotEnough };
                    Length = StringByteUtils.ToInt32(data, head.Length + 0, true);
                    break;
                case HLType.输入固定长度:
                    Length = int.Parse(parserConfig.Item2["HLLength"]);
                    break;
                default:
                    break;
            }
            return new GetDataLengthRsp()
            {
                Length = Length,
                StateCode = Parser.StateCode.Success
            };
        }

        private async Task TcpServer_OnClientDisconnect(Guid clientId)
        {
            Global.DataReceives.TryRemove(clientId, out var dr);
            await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
            {
                tabControl1.TabPages[clientId.ToString()]!.Text += " 测试关闭";
                tabControl1.TabPages[clientId.ToString()]!.Name = string.Empty;
                CloseTabPage();
            })), EndInvoke);
        }

        private async Task TcpServer_OnClientConnect(Guid clientId)
        {
            await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
            {
                var dr = new DataReceive();
                Global.DataReceives.TryAdd(clientId, dr);
                dr.Dock = DockStyle.Fill;
                var info = await ((TcpServer)Global.TcpServer!.PhysicalPort).GetClientInfo(clientId);
                if (info.HasValue)
                {
                    tabPage = new TabPage($"TCPServer ClientConnect:{info.Value.IPAddress}:{info.Value.Port}")
                    {
                        Name = clientId.ToString()
                    };
                    tabPage.Controls.Add(dr);
                    tabPage.Tag = clientId;
                    tabControl1.TabPages.Add(tabPage);
                    tabControl1.SelectedTab = tabPage;
                }
            })), EndInvoke);
        }

        private async Task TcpServer_OnReceiveParsedData(Guid clientId, byte[] data)
        {
            await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
            {
                if (!Global.DataReceives.TryGetValue(clientId, out var dr)) return;
                await dr.AddDataAsync(data);
                if (await Global.AutoReplyConfig!.AutoReplyAsync())
                {
                    var (value, delayTime) = await Global.AutoReplyConfig.GetAsync(data);
                    if (value is not null)
                    {
                        await Task.Delay(delayTime);
                        await Global.TcpServer!.SendAsync(clientId, value);
                    }
                }
            })), EndInvoke);
            await Task.Delay(20);
        }

        private static async Task TopPort_OnReceiveParsedData(byte[] data, DataReceive dataReceive)
        {
            await dataReceive.AddDataAsync(data);
            if (await Global.AutoReplyConfig!.AutoReplyAsync())
            {
                var (value, delayTime) = await Global.AutoReplyConfig.GetAsync(data);
                if (value is not null)
                {
                    await Task.Delay(delayTime);
                    await Global.TopPort!.SendAsync(value);
                }
            }
        }

        private async Task SendCmd(SendCmd sendCmd)
        {
            if (!isConnect) return;
            var cmd = sendCmd.Cmd;
            switch (sendCmd.CrcType)
            {
                case Config.SendList.CrcType.None:
                    break;
                case Config.SendList.CrcType.Modbus:
                    cmd = StringByteUtils.ComibeByteArray(cmd, CRC.Crc16(cmd, cmd.Length));
                    break;
                case Config.SendList.CrcType.Crc16_R:
                    cmd = StringByteUtils.ComibeByteArray(cmd, CRC.CRC16_R(cmd));
                    break;
                case Config.SendList.CrcType.UpdateCRC:
                    cmd = StringByteUtils.ComibeByteArray(cmd, StringByteUtils.GetBytes(CRC.UpdateCRC(cmd, cmd.Length), true));
                    break;
                case Config.SendList.CrcType.GBcrc16:
                    cmd = StringByteUtils.ComibeByteArray(cmd, CRC.GBcrc16(cmd, cmd.Length));
                    break;
                case Config.SendList.CrcType.HBcrc16:
                    cmd = StringByteUtils.ComibeByteArray(cmd, CRC.HBcrc16(cmd, cmd.Length));
                    break;
                case Config.SendList.CrcType.GBcrc16_string:
                    cmd = StringByteUtils.ComibeByteArray(cmd, Encoding.GetEncoding("gb2312").GetBytes(StringByteUtils.BytesToString(CRC.GBcrc16(cmd, cmd.Length)).Replace(" ", "")));
                    break;
                case Config.SendList.CrcType.HBcrc16_string:
                    cmd = StringByteUtils.ComibeByteArray(cmd, Encoding.GetEncoding("gb2312").GetBytes(StringByteUtils.BytesToString(CRC.HBcrc16(cmd, cmd.Length)).Replace(" ", "")));
                    break;
                case Config.SendList.CrcType.H_GBcrc16_string:
                    {
                        var strCmd = Encoding.GetEncoding("gb2312").GetString(cmd);
                        cmd = Encoding.GetEncoding("gb2312").GetBytes($"##{strCmd.Length.ToString().PadLeft(4, '0')}{strCmd}{StringByteUtils.BytesToString(CRC.GBcrc16(cmd, cmd.Length)).Replace(" ", "")}");
                    }
                    break;
                case Config.SendList.CrcType.H_HBcrc16_string:
                    {
                        var strCmd = Encoding.GetEncoding("gb2312").GetString(cmd);
                        cmd = Encoding.GetEncoding("gb2312").GetBytes($"##{strCmd.Length.ToString().PadLeft(4, '0')}{strCmd}{StringByteUtils.BytesToString(CRC.HBcrc16(cmd, cmd.Length)).Replace(" ", "")}");
                    }
                    break;
                default:
                    break;
            }
            if (sendCmd.HaveR) cmd = StringByteUtils.ComibeByteArray(cmd, [0x0d]);
            if (sendCmd.HaveN) cmd = StringByteUtils.ComibeByteArray(cmd, [0x0a]);
            var connectionConfig = await Global.ConnectionConfig!.GetAsync();
            if (!isConnect) return;
            switch (connectionConfig.Item1)
            {
                case ConnectionType.SerialPort:
                    {
                        await Global.TopPort!.SendAsync(cmd);
                    }
                    break;
                case ConnectionType.TCPServer:
                    var (isEnd, clientId) = ((bool isEnd, Guid? clientId))await Task.Factory.FromAsync<object>(BeginInvoke(new Func<(bool, Guid?)>(() =>
                    {
                        if (tabControl1.SelectedTab is null) return (true, null);
                        return (tabControl1.SelectedTab.Text.Contains("测试关闭"), (Guid?)tabControl1.SelectedTab.Tag);
                    })), EndInvoke!);
                    if (isEnd) return;
                    await Global.TcpServer!.SendAsync((Guid)clientId!, cmd);
                    break;
                case ConnectionType.TCPClient:
                    {
                        await Global.TopPort!.SendAsync(cmd);
                    }
                    break;
                default:
                    break;
            }
        }

        private async void BtnSendList_Click(object sender, EventArgs e)
        {
            if (btnSendList.Text == "循环发送列表勾选")
            {
                _task = Task.Run(async () =>
                {
                    _closeCts = new CancellationTokenSource();

                    while (!_closeCts.IsCancellationRequested)
                    {
                        foreach (var item in await Global.SendListConfig!.GetUsedAsync())
                        {
                            await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    var tag = row.Tag;
                                    if (tag is null) continue;
                                    if (((SendCmd)tag).ID == item.ID)
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(252, 213, 180);
                                    }
                                    else
                                    {
                                        row.DefaultCellStyle.BackColor = Color.White;
                                    }
                                    await Task.CompletedTask;
                                }
                            })), EndInvoke);
                            await SendCmd(item);
                            await Task.Delay(int.Parse(tbTime.Text));
                        }
                    }
                });
                btnSendList.Text = "停止";
            }
            else
            {
                _closeCts?.Cancel();
                if (_task is not null) await _task;
                btnSendList.Text = "循环发送列表勾选";
            }
        }

        private async void 通讯配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connectionConfig = new ConnectionConfig();
            connectionConfig.ShowDialog();
            await RefreshStatus();
        }

        private async void 分包规则ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parserConfig = new ParserConfig();
            parserConfig.ShowDialog();
            await RefreshStatus();
        }

        private void 自动回复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var autoReply = new AutoReply();
            autoReply.ShowDialog();
        }

        private void 导出配置ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            var file = new SaveFileDialog
            {
                Filter = "配置文件(*.csconfig)|*.csconfig"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                using var source = new SqliteConnection(string.Format("Data Source = {0}", Global.DBPath));
                using var destination = new SqliteConnection(string.Format("Data Source = {0}", file.FileName));
                source.Open();
                destination.Open();
                source.BackupDatabase(destination);
            }
        }

        private async void 导入配置ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            var dialog = new OpenFileDialog
            {
                Title = "请选配置文件",
                Filter = "配置文件(*.csconfig)|*.csconfig"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("是否导入为默认配置？\n若不是默认，下次打开将还原", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Global.DBPath = Global.DPath;
                    File.Copy(dialog.FileName, Global.DBPath, true);
                }
                else
                {
                    Global.DBPath = dialog.FileName;
                }
                Global.AutoReplyConfig = new AutoReplyConfigManager();
                Global.ConnectionConfig = new ConnectionConfigManager();
                Global.ParserConfig = new ParserConfigManager();
                Global.SendListConfig = new SendListConfigManager();
                dataGridView1.RowsRemoved -= DataGridView1_RowsRemoved;
                await RefreshDataGridView();
                dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            }
        }

        private void 系统关联toolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                string keyName = "csconfig";
                string keyValue = "通讯测试工具配置文件";
                RegistryKey key, keyico;
                key = Registry.ClassesRoot.CreateSubKey(keyName);
                key.SetValue("Create", Application.ExecutablePath.ToString());

                keyico = key.CreateSubKey("DefaultIcon");
                keyico.SetValue("", Application.ExecutablePath + ",0");

                key.SetValue("", keyValue);
                key = key.CreateSubKey("Shell");
                key = key.CreateSubKey("Open");
                key = key.CreateSubKey("Command");

                // 关联的位置 
                key.SetValue("", "\"" + Application.ExecutablePath.ToString() + "\" \"%1\"");

                // 关联的文件扩展名
                keyName = ".csconfig";
                keyValue = "csconfig";
                key = Registry.ClassesRoot.CreateSubKey(keyName);
                key.SetValue("", keyValue);
                key.Close();
                MainHelpers.SHChangeNotify(0x8000000, 0, IntPtr.Zero, IntPtr.Zero);
                MessageBox.Show("设置文件关联操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HexCalcToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var hexCalc = new HexCalc();
            hexCalc.Show();
        }

        private void CrcCalcToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var crcCalc = new CrcCalc();
            crcCalc.Show();
        }

        private void 显隐toolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            ((ToolStripMenuItem)sender).Text = splitContainer1.Panel2Collapsed ? "显示" : "隐藏";
        }

        private async void CbAutoReply_CheckedChangedAsync(object sender, EventArgs e)
        {
            await Global.AutoReplyConfig!.SetAutoReplyAsync(cbAutoReply.Checked);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CloseTabPage();
        }

        private void CloseTabPage()
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Text.Contains("测试关闭"))
            {
                tabControl1.ContextMenuStrip = contextMenuStrip1;
            }
            else
            {
                tabControl1.ContextMenuStrip = null;
            }
        }

        private async void CbAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            await Global.ConnectionConfig!.SetAutoConnectAsync(cbAutoConnect.Checked);
        }

        private async void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["Cmd"].Value?.ToString()))
            {
                try
                {
                    var sendType = (SendType)Enum.Parse(typeof(SendType), dataGridView1.Rows[e.RowIndex].Cells["SendType"].EditedFormattedValue.ToString()!);

                    var sendCmd = new SendCmd()
                    {
                        ID = (((SendCmd)dataGridView1.Rows[e.RowIndex].Tag!)?.ID) ?? ++_maxID,
                        Used = (bool)dataGridView1.Rows[e.RowIndex].Cells["Used"].EditedFormattedValue,
                        CName = dataGridView1.Rows[e.RowIndex].Cells["CName"].Value?.ToString() ?? "",
                        SendType = sendType,
                        HaveR = (bool)dataGridView1.Rows[e.RowIndex].Cells["r"].EditedFormattedValue,
                        HaveN = (bool)dataGridView1.Rows[e.RowIndex].Cells["n"].EditedFormattedValue,
                        CrcType = (CrcType)Enum.Parse(typeof(CrcType), dataGridView1.Rows[e.RowIndex].Cells["CrcType"].EditedFormattedValue.ToString()!)
                    };
                    string cmd = dataGridView1.Rows[e.RowIndex].Cells["Cmd"].Value?.ToString()!;
                    switch (sendType)
                    {
                        case Config.SendList.SendType.Hex:
                            sendCmd.Cmd = StringByteUtils.StringToBytes(cmd);
                            break;
                        case Config.SendList.SendType.ASCII:
                            sendCmd.Cmd = Encoding.ASCII.GetBytes(cmd);
                            break;
                        case Config.SendList.SendType.UTF8:
                            sendCmd.Cmd = Encoding.UTF8.GetBytes(cmd);
                            break;
                        case Config.SendList.SendType.GB2312:
                            sendCmd.Cmd = Encoding.GetEncoding(sendType.ToString()).GetBytes(cmd);
                            break;
                        default:
                            break;
                    }
                    await Global.SendListConfig!.AddOrUpdateAsync(sendCmd);
                    dataGridView1.Rows[e.RowIndex].Tag = sendCmd;
                }
                catch (Exception)
                {
                    MessageBox.Show("命令输入有误");
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        //CellEnter-->CellBeginEdit-->CellLeave-->CellValidating-->CellValueChanged-->CellValidated-->CellEndEdit
        private async void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridView1[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell && dataGridView1.Rows[e.RowIndex].Tag != null)
            {
                await SendCmd((SendCmd)dataGridView1.Rows[e.RowIndex].Tag!);
            }
            else if (dataGridView1[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell)
            {
                this.Validate();
            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("数据库不匹配，点击确认重启，程序将启动自动修复");
            try
            {
                File.Delete(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PairsDB.dll"));
                MessageBox.Show("自动修复成功，即将重启");
                Application.Restart();
            }
            catch (Exception)
            {
                MessageBox.Show("修复失败，请联系曹一梁");
                Environment.Exit(0);
            }
        }

        private async void DataGridView1_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (_selectID.HasValue)
                await Global.SendListConfig!.RemoveAsync((int)_selectID);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _selectID = ((SendCmd)dataGridView1.SelectedRows[0].Tag!)?.ID;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
        }

        private void ComboBox_DropDownClosed(object? sender, EventArgs e)
        {
            this.Validate();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dataGridView1.EndEdit();
            }
            else if (dataGridView1.EditMode != DataGridViewEditMode.EditOnEnter)
            {
                dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
                dataGridView1.BeginEdit(true);
                if (dataGridView1.EditingControl != null && dataGridView1.EditingControl is DataGridViewComboBoxEditingControl)
                {
                    var comboBox = dataGridView1.EditingControl as DataGridViewComboBoxEditingControl;
                    if (comboBox is not null) comboBox.SelectionChangeCommitted += ComboBox_DropDownClosed;
                }
            }
            else
            {
                dataGridView1.BeginEdit(true);
                if (dataGridView1.EditingControl != null && dataGridView1.EditingControl is DataGridViewComboBoxEditingControl)
                {
                    var comboBox = dataGridView1.EditingControl as DataGridViewComboBoxEditingControl;
                    if (comboBox is not null)
                    {
                        comboBox.DropDownClosed -= ComboBox_DropDownClosed;
                        comboBox.DropDownClosed += ComboBox_DropDownClosed;
                    }
                }
            }
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;
            if (datagridview is not null)
                // Check to make sure the cell clicked is the cell containing the combobox 
                if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
                {
                    datagridview.BeginEdit(true);
                    ((ComboBox)datagridview.EditingControl).DroppedDown = true;
                }
        }

        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
