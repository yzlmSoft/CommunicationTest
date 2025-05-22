using CommunicationTest.Config.Connection;
using FastDeepCloner;
using System.IO.Ports;
using System.Management;
using System.Net;

namespace CommunicationTest
{
    public partial class ConnectionConfig : Form
    {
        public ConnectionConfig()
        {
            InitializeComponent();
        }

        private async void ConnectionConfig_LoadAsync(object sender, EventArgs e)
        {
            RefreshPortNames();
            foreach (string parity in Enum.GetNames(typeof(Parity)))
            {
                controlParity.Items.Add(parity);
            }
            foreach (string StopBits in Enum.GetNames(typeof(StopBits)))
            {
                controlStopBits.Items.Add(StopBits);
            }
            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in ipHostEntry.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {//筛选IPV4
                    controlTCPServerIP.Items.Add(ip.ToString());
                }
            }
            var config = await Global.ConnectionConfig!.GetAsync();
            foreach (var item in config.Item2)
            {
                if (item.Key == "Dtr" || item.Key == "Rts")
                {
                    ((CheckBox)tabControl1.Controls.Find($"cb{item.Key}", true)[0]).Checked = bool.Parse(item.Value);
                }
                else
                {
                    tabControl1.Controls.Find($"control{item.Key}", true)[0].Text = item.Value;
                }
            }
            tabControl1.SelectedIndex = (int)config.Item1;
        }

        private void RefreshPortNames()
        {
            controlPortName.Items.Clear();
            // 用于存储端口号和设备名的映射
            var portNames = SerialPort.GetPortNames();
            var portDescriptions = new Dictionary<string, string>();

            // 使用WMI获取设备描述
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'"))
            {
                foreach (var obj in searcher.Get())
                {
                    var name = obj["Name"]?.ToString();
                    if (name != null)
                    {
                        // 匹配所有 (COMx)
                        var matches = System.Text.RegularExpressions.Regex.Matches(name, @"COM\d+");
                        foreach (System.Text.RegularExpressions.Match match in matches)
                        {
                            var port = match.Value; // 得到 COM1、COM2
                            portDescriptions[port] = name;
                        }
                    }
                }
            }

            // 组合显示
            foreach (var port in portNames)
            {
                if (portDescriptions.TryGetValue(port, out var desc))
                {
                    // 去掉括号及其内容，只保留设备名
                    var deviceName = System.Text.RegularExpressions.Regex.Replace(desc, @"\s*\(.*?\)", "").Trim();
                    controlPortName.Items.Add($"{port} - {deviceName}");
                }
                else
                {
                    controlPortName.Items.Add(port);
                }
            }
        }

        private async void ConnectionConfig_FormClosingAsync(object sender, FormClosingEventArgs e)
        {
            var config = await Global.ConnectionConfig!.GetAsync();
            foreach (var item in config.Item2.Clone())
            {
                if (item.Key == "Dtr" || item.Key == "Rts")
                {
                    config.Item2[item.Key] = ((CheckBox)tabControl1.Controls.Find($"cb{item.Key}", true)[0]).Checked.ToString();
                }
                else
                {
                    config.Item2[item.Key] = tabControl1.Controls.Find($"control{item.Key}", true)[0].Text;
                }
            }
            await Global.ConnectionConfig.SetAsync((ConnectionType)Enum.Parse(typeof(ConnectionType), tabControl1.SelectedTab.Text), config.Item2);
        }
    }
}
