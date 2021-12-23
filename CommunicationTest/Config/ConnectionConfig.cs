using CommunicationTest.Config.Connection;
using FastDeepCloner;
using System.IO.Ports;
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
            var config = await Global.ConnectionConfig.GetAsync();
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
            controlPortName.Items.AddRange(SerialPort.GetPortNames());
        }

        private async void ConnectionConfig_FormClosingAsync(object sender, FormClosingEventArgs e)
        {
            var config = await Global.ConnectionConfig.GetAsync();
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
