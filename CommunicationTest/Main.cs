﻿using Communication.Bus;
using Communication.Bus.PhysicalPort;
using Parser;
using Parser.Interfaces;
using Parser.Parsers;
using CommunicationTest.Config.AutoReply;
using CommunicationTest.Config.Connection;
using CommunicationTest.Config.Parser;
using CommunicationTest.Config.SendList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopPortLib;
using Utils;

namespace CommunicationTest
{
    public partial class Main : Form
    {
        CancellationTokenSource _closeCts;
        Task _task;

        bool isConnect = false;
        TabPage tabPage;
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
            if (await Global.ConnectionConfig.AutoConnectAsync())
            {
                btnConnect.PerformClick();
            }
            cbAutoConnect.Checked = await Global.ConnectionConfig.AutoConnectAsync();
            cbAutoReply.Checked = await Global.AutoReplyConfig.AutoReplyAsync();
            await RefreshStatus();
            await RefreshDataGridView();
        }

        private async Task RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            var sendList = await Global.SendListConfig.GetAsync();
            if (sendList.Count > 0)
            {
                sendList.Sort((x, y) => x.ID.CompareTo(y.ID));
                _maxID = sendList[^1].ID;
            }
            foreach (var item in sendList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = item;
                DataGridViewCheckBoxCell Used = new DataGridViewCheckBoxCell();
                Used.Value = item.Used;
                row.Cells.Add(Used);
                DataGridViewTextBoxCell CName = new DataGridViewTextBoxCell();
                CName.Value = item.CName;
                row.Cells.Add(CName);
                DataGridViewComboBoxCell SendType = new DataGridViewComboBoxCell();
                var dt = new DataTable();
                dt.Columns.Add(new DataColumn("SendType"));
                Enum.GetNames(typeof(SendType)).ToList().ForEach(x => dt.Rows.Add(x));
                SendType.DataSource = dt;
                SendType.DisplayMember = "SendType";
                SendType.Value = item.SendType.ToString();
                row.Cells.Add(SendType);
                DataGridViewTextBoxCell Cmd = new DataGridViewTextBoxCell();
                switch (item.SendType)
                {
                    case Config.SendList.SendType.Hex:
                        Cmd.Value = StringByteUtils.BytesToString(item.Cmd);
                        break;
                    case Config.SendList.SendType.ASCII:
                        Cmd.Value = Encoding.ASCII.GetString(item.Cmd);
                        break;
                    case Config.SendList.SendType.UTF8:
                        Cmd.Value = Encoding.UTF8.GetString(item.Cmd);
                        break;
                    case Config.SendList.SendType.GB2312:
                        Cmd.Value = Encoding.GetEncoding(item.SendType.ToString()).GetString(item.Cmd);
                        break;
                    default:
                        Cmd.Value = StringByteUtils.BytesToString(item.Cmd);
                        break;
                }
                row.Cells.Add(Cmd);
                DataGridViewCheckBoxCell r = new DataGridViewCheckBoxCell();
                r.Value = item.HaveR;
                row.Cells.Add(r);
                DataGridViewCheckBoxCell n = new DataGridViewCheckBoxCell();
                n.Value = item.HaveN;
                row.Cells.Add(n);
                dataGridView1.Rows.Add(row);
            }
        }

        private async Task RefreshStatus()
        {
            var connectionConfig = await Global.ConnectionConfig.GetAsync();
            var parserConfig = await Global.ParserConfig.GetAsync();

            switch (connectionConfig.Item1)
            {
                case ConnectionType.SerialPort:
                    btnConnect.Text = isConnect ? "关闭串口" : "打开串口";
                    toolStripStatusLabel1.Text = $"当前 [连接方式:{connectionConfig.Item1}] [分包方式:{parserConfig.Item1}] [连接状态:{isConnect}]";
                    break;
                case ConnectionType.TCPServer:
                    btnConnect.Text = isConnect ? "停止监听" : "监听";
                    toolStripStatusLabel1.Text = $"当前 [连接方式:{connectionConfig.Item1}] [分包方式:{parserConfig.Item1}] [监听状态:{isConnect}]";
                    break;
                case ConnectionType.TCPClient:
                    btnConnect.Text = isConnect ? "断开连接" : "连接";
                    toolStripStatusLabel1.Text = $"当前 [连接方式:{connectionConfig.Item1}] [分包方式:{parserConfig.Item1}] [连接状态:{isConnect}]";
                    break;
                default:
                    break;
            }
            通讯配置ToolStripMenuItem.Enabled = !isConnect;
            分包规则ToolStripMenuItem.Enabled = !isConnect;
            导入配置ToolStripMenuItem.Enabled = !isConnect;
            导出配置ToolStripMenuItem.Enabled = !isConnect;
        }

        private async void btnConnect_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var connectionConfig = await Global.ConnectionConfig.GetAsync();
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
                                var serialPort = new Communication.Bus.PhysicalPort.SerialPort(portName, baudRate, parity, dataBits, stopBits);
                                serialPort.DtrEnable = bool.Parse(connectionConfig.Item2["Dtr"]);
                                serialPort.RtsEnable = bool.Parse(connectionConfig.Item2["Rts"]);
                                Global.TopPort = new TopPort(serialPort, Global.Parser);
                                var dr = new DataReceive();
                                Global.TopPort.OnReceiveParsedData += async data => await TopPort_OnReceiveParsedData(data, dr);
                                await Global.TopPort.OpenAsync();

                                dr.Dock = DockStyle.Fill;
                                tabPage = new TabPage(portName);
                                tabPage.Controls.Add(dr);
                                tabControl1.TabPages.Add(tabPage);
                                tabControl1.SelectedTab = tabPage;
                            }
                            break;
                        case ConnectionType.TCPServer:
                            {
                                var TCPServerIP = connectionConfig.Item2["TCPServerIP"] == "Any" ? IPAddress.Any.ToString() : connectionConfig.Item2["TCPServerIP"];
                                var TCPServerPort = int.Parse(connectionConfig.Item2["TCPServerPort"]);
                                Global.TcpServer = new TcpServer(TCPServerIP, TCPServerPort);
                                Global.TcpServer.OnReceiveOriginalDataFromTcpClient += TcpServer_OnReceiveOriginalDataFromTcpClient; ;
                                Global.TcpServer.OnClientConnect += TcpServer_OnClientConnect;
                                Global.TcpServer.OnClientDisconnect += TcpServer_OnClientDisconnect;
                                await Global.TcpServer.StartAsync();
                            }
                            break;
                        case ConnectionType.TCPClient:
                            {
                                var TCPClientIP = connectionConfig.Item2["TCPClientIP"] == "Any" ? IPAddress.Any.ToString() : connectionConfig.Item2["TCPClientIP"];
                                var TCPClientPort = int.Parse(connectionConfig.Item2["TCPClientPort"]);
                                Global.TopPort = new TopPort(new TcpClient(TCPClientIP, TCPClientPort), Global.Parser);
                                var dr = new DataReceive();
                                Global.TopPort.OnReceiveParsedData += async data => await TopPort_OnReceiveParsedData(data, dr);
                                await Global.TopPort.OpenAsync();

                                dr.Dock = DockStyle.Fill;
                                tabPage = new TabPage($"{TCPClientIP}:{TCPClientPort}");
                                tabPage.Controls.Add(dr);
                                tabControl1.TabPages.Add(tabPage);
                                tabControl1.SelectedTab = tabPage;
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
                            await Global.TcpServer.StopAsync();
                            break;
                        case ConnectionType.SerialPort:
                        case ConnectionType.TCPClient:
                            await Global.TopPort.CloseAsync();
                            tabPage.Text += " 本次测试结束";
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
        }

        private static async Task<IParser> NewParser()
        {
            var parserConfig = await Global.ParserConfig.GetAsync();

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
            var parserConfig = await Global.ParserConfig.GetAsync();
            var head = StringByteUtils.StringToBytes(parserConfig.Item2["HLHead"]);
            int Length = 0;
            switch ((HLType)Enum.Parse(typeof(HLType), parserConfig.Item2["HLType"]))
            {
                case HLType.头后FloatL:
                    if (data.Length < head.Length + 4) return new GetDataLengthRsp() { ErrorCode = Parser.ErrorCode.LengthNotEnough };
                    Length = (int)StringByteUtils.ToSingle(data, head.Length + 0);
                    break;
                case HLType.头后FloatH:
                    if (data.Length < head.Length + 4) return new GetDataLengthRsp() { ErrorCode = Parser.ErrorCode.LengthNotEnough };
                    Length = (int)StringByteUtils.ToSingle(data, head.Length + 0, true);
                    break;
                case HLType.头后ShortL:
                    if (data.Length < head.Length + 2) return new GetDataLengthRsp() { ErrorCode = Parser.ErrorCode.LengthNotEnough };
                    Length = StringByteUtils.ToInt16(data, head.Length + 0);
                    break;
                case HLType.头后ShortH:
                    if (data.Length < head.Length + 2) return new GetDataLengthRsp() { ErrorCode = Parser.ErrorCode.LengthNotEnough };
                    Length = StringByteUtils.ToInt16(data, head.Length + 0, true);
                    break;
                case HLType.头后Int32L:
                    if (data.Length < head.Length + 4) return new GetDataLengthRsp() { ErrorCode = Parser.ErrorCode.LengthNotEnough };
                    Length = StringByteUtils.ToInt32(data, head.Length + 0);
                    break;
                case HLType.头后Int32H:
                    if (data.Length < head.Length + 4) return new GetDataLengthRsp() { ErrorCode = Parser.ErrorCode.LengthNotEnough };
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
                ErrorCode = Parser.ErrorCode.Success
            };
        }

        private async Task TcpServer_OnClientDisconnect(int clientId)
        {
            Global.Parsers.TryRemove(clientId, out var Parser);
            await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
            {
                tabControl1.TabPages[clientId.ToString()].Text += " 本次测试结束";
                CloseTabPage();
            })), EndInvoke);
        }

        private async Task TcpServer_OnClientConnect(string hostName, int port, int clientId)
        {
            await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
            {
                var dr = new DataReceive();
                var parser = await NewParser();
                parser.OnReceiveParsedData += async data => await Parser_OnReceiveParsedData(data, clientId, dr);
                Global.Parsers.TryAdd(clientId, parser);
                dr.Dock = DockStyle.Fill;
                tabPage = new TabPage($"TCPServer ClientConnect:{hostName}:{port}");
                tabPage.Name = clientId.ToString();
                tabPage.Controls.Add(dr);
                tabPage.Tag = clientId;
                tabControl1.TabPages.Add(tabPage);
                tabControl1.SelectedTab = tabPage;
            })), EndInvoke);
        }

        private async Task Parser_OnReceiveParsedData(byte[] data, int clientId, DataReceive dataReceive)
        {
            await dataReceive.AddDataAsync(data);
            if (await Global.AutoReplyConfig.AutoReplyAsync())
            {
                var send = await Global.AutoReplyConfig.GetAsync(data);
                if (!(send is null))
                {
                    await Global.TcpServer.SendDataAsync(clientId, send);
                    await dataReceive.AddDataAsync(send, true);
                }
            }
        }

        private async Task TcpServer_OnReceiveOriginalDataFromTcpClient(byte[] data, int size, int clientId)
        {
            if (Global.Parsers.TryGetValue(clientId, out var parser))
            {
                await parser.ReceiveOriginalDataAsync(data, size);
            }
        }

        private async Task TopPort_OnReceiveParsedData(byte[] data, DataReceive dataReceive)
        {
            await dataReceive.AddDataAsync(data);
            if (await Global.AutoReplyConfig.AutoReplyAsync())
            {
                var send = await Global.AutoReplyConfig.GetAsync(data);
                if (!(send is null))
                {
                    await Global.TopPort.SendAsync(send);
                    await dataReceive.AddDataAsync(send, true);
                }
            }
        }

        private async Task SendCmd(SendCmd sendCmd)
        {
            if (!isConnect) return;
            var cmd = sendCmd.Cmd;
            if (sendCmd.HaveR) cmd = StringByteUtils.ComibeByteArray(cmd, new byte[] { 0x0d });
            if (sendCmd.HaveN) cmd = StringByteUtils.ComibeByteArray(cmd, new byte[] { 0x0a });
            var connectionConfig = await Global.ConnectionConfig.GetAsync();
            switch (connectionConfig.Item1)
            {
                case ConnectionType.SerialPort:
                    {
                        await Global.TopPort.SendAsync(cmd);
                        await (tabControl1.SelectedTab.Controls[0] as DataReceive).AddDataAsync(cmd, true);
                    }
                    break;
                case ConnectionType.TCPServer:
                    if (tabControl1.SelectedTab != null)
                    {
                        await Global.TcpServer.SendDataAsync((int)tabControl1.SelectedTab.Tag, cmd);
                        await (tabControl1.SelectedTab.Controls[0] as DataReceive).AddDataAsync(cmd, true);
                    }
                    break;
                case ConnectionType.TCPClient:
                    {
                        await Global.TopPort.SendAsync(cmd);
                        await (tabControl1.SelectedTab.Controls[0] as DataReceive).AddDataAsync(cmd, true);
                    }
                    break;
                default:
                    break;
            }
        }

        private async void btnSendList_Click(object sender, EventArgs e)
        {
            if (btnSendList.Text == "循环发送列表勾选")
            {
                _task = Task.Run(async () =>
                {
                    _closeCts = new CancellationTokenSource();

                    while (!_closeCts.IsCancellationRequested)
                    {
                        foreach (var item in await Global.SendListConfig.GetUsedAsync())
                        {
                            await SendCmd(item);
                            await Task.Delay(int.Parse(tbTime.Text));
                        }
                    }
                });
                btnSendList.Text = "停止";
            }
            else
            {
                _closeCts.Cancel();
                await _task;
                btnSendList.Text = "循环发送列表勾选";
            }
        }

        private async void 通讯配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionConfig connectionConfig = new ConnectionConfig();
            connectionConfig.ShowDialog();
            await RefreshStatus();
        }

        private async void 分包规则ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParserConfig parserConfig = new ParserConfig();
            parserConfig.ShowDialog();
            await RefreshStatus();
        }

        private void 自动回复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoReply autoReply = new AutoReply();
            autoReply.ShowDialog();
        }

        private void 导出配置ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "配置文件(*.csconfig)|*.csconfig";
            if (file.ShowDialog() == DialogResult.OK)
            {
                File.Copy(Global.DBPath, file.FileName, true);
            }
        }

        private async void 导入配置ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选配置文件";
            dialog.Filter = "配置文件(*.csconfig)|*.csconfig";
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
                dataGridView1.RowsRemoved -= dataGridView1_RowsRemoved;
                await RefreshDataGridView();
                dataGridView1.RowsRemoved += dataGridView1_RowsRemoved;
            }
        }

        private void HexCalcToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            HexCalc hexCalc = new HexCalc();
            hexCalc.Show();
        }

        private void 显隐toolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            ((ToolStripMenuItem)sender).Text = splitContainer1.Panel2Collapsed ? "显示" : "隐藏";
        }

        private async void cbAutoReply_CheckedChangedAsync(object sender, EventArgs e)
        {
            await Global.AutoReplyConfig.SetAutoReplyAsync(cbAutoReply.Checked);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CloseTabPage();
        }

        private void CloseTabPage()
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Text.Contains("本次测试结束"))
            {
                tabControl1.ContextMenuStrip = contextMenuStrip1;
            }
            else
            {
                tabControl1.ContextMenuStrip = null;
            }
        }

        private async void cbAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            await Global.ConnectionConfig.SetAutoConnectAsync(cbAutoConnect.Checked);
        }

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["Cmd"].Value?.ToString()))
            {
                try
                {
                    var sendType = (SendType)Enum.Parse(typeof(SendType), dataGridView1.Rows[e.RowIndex].Cells["SendType"].EditedFormattedValue.ToString());

                    var sendCmd = new SendCmd()
                    {
                        ID = (((SendCmd)dataGridView1.Rows[e.RowIndex].Tag)?.ID) ?? ++_maxID,
                        Used = (bool)dataGridView1.Rows[e.RowIndex].Cells["Used"].EditedFormattedValue,
                        CName = dataGridView1.Rows[e.RowIndex].Cells["CName"].Value?.ToString() ?? "",
                        SendType = sendType,
                        HaveR = (bool)dataGridView1.Rows[e.RowIndex].Cells["r"].EditedFormattedValue,
                        HaveN = (bool)dataGridView1.Rows[e.RowIndex].Cells["n"].EditedFormattedValue,
                    };
                    string cmd = dataGridView1.Rows[e.RowIndex].Cells["Cmd"].Value?.ToString();
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
                    await Global.SendListConfig.AddOrUpdateAsync(sendCmd);
                    dataGridView1.Rows[e.RowIndex].Tag = sendCmd;
                    var a = await Global.SendListConfig.GetAsync();
                }
                catch (Exception)
                {

                }
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridView1[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell && dataGridView1.Rows[e.RowIndex].Tag != null)
            {
                await SendCmd((SendCmd)dataGridView1.Rows[e.RowIndex].Tag);
            }
            else if (dataGridView1[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell || dataGridView1[e.ColumnIndex, e.RowIndex] is DataGridViewComboBoxCell)
            {
                this.Validate();
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private async void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (_selectID.HasValue)
                await Global.SendListConfig.RemoveAsync((int)_selectID);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _selectID = ((SendCmd)dataGridView1.SelectedRows[0].Tag)?.ID;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
        }
    }
}
