using System.Text;
using Utils;

namespace CommunicationTest
{
    public partial class HexCalc : Form
    {
        public HexCalc()
        {
            InitializeComponent();
        }

        private void CbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cbTopMost.Checked;
        }

        private void BtnHexToFloat_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(rtbInput.Text)) return;
            btnHexToFloat.Enabled = false;

            string[] splitStr = rtbInput.Text.Split('\n');

            _ = Task.Run(async () =>
            {
                var stringBuilder = new StringBuilder();
                for (int j = 0; j < splitStr.Length; j++)
                {
                    try
                    {
                        byte[] Data = StringByteUtils.StringToBytes(splitStr[j]);
                        if (Data.Length % 4 != 0) MessageBox.Show("请正确输入数据!(每一行字节数必须是4的倍数)[第" + (j + 1) + "行]");
                        for (int i = 0; i < Data.Length / 4; i++)
                        {
                            if (cbHB.Checked)
                            {
                                byte[] temp = new byte[4];
                                Array.Copy(Data, i * 4, temp, 0, 4);
                                Array.Reverse(temp);
                                stringBuilder.Append(BitConverter.ToSingle(temp, 0).ToString() + tbSplit.Text);
                            }
                            else
                            {
                                stringBuilder.Append(BitConverter.ToSingle(Data, i * 4).ToString() + tbSplit.Text);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("请正确输入需要转换的内容![第" + (j + 1) + "行]");
                    }
                    stringBuilder.Append('\n');
                }
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    rtbOutput.AppendText(stringBuilder.ToString());
                    btnHexToFloat.Enabled = true;
                })), EndInvoke);
            });
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFloatToHex_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(rtbInput.Text)) return;
            btnFloatToHex.Enabled = false;

            string[] splitStr = rtbInput.Text.Split('\n');

            _ = Task.Run(async () =>
            {
                var stringBuilder = new StringBuilder();
                for (int j = 0; j < splitStr.Length; j++)
                {
                    string[] items = splitStr[j].Split(new string[] { tbSplit.Text }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < items.Length; i++)
                    {
                        try
                        {
                            float tempf = float.Parse(items[i]);
                            byte[] tempb = BitConverter.GetBytes(tempf);
                            if (cbHB.Checked) Array.Reverse(tempb);
                            stringBuilder.Append(StringByteUtils.BytesToString(tempb));
                        }
                        catch
                        {
                            MessageBox.Show("请输入正确要转换的数[第" + (j + 1) + "行,第" + (i + 1) + "个]");
                        }
                    }
                    stringBuilder.Append('\n');
                }
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    rtbOutput.AppendText(stringBuilder.ToString());
                    btnFloatToHex.Enabled = true;
                })), EndInvoke);
            });
        }

        private void BtnClearInput_Click(object sender, EventArgs e)
        {
            rtbInput.Text = string.Empty;
        }

        private void BtnHexToAscii_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(rtbInput.Text)) return;
            btnHexToAscii.Enabled = false;

            var content = rtbInput.Text;
            _ = Task.Run(async () =>
            {
                try
                {
                    string str = Encoding.ASCII.GetString(StringByteUtils.StringToBytes(content));
                    await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                    {
                        rtbOutput.AppendText(str);
                    })), EndInvoke);
                }
                catch
                {
                    MessageBox.Show("请正确输入需要转换的内容");
                }
                finally
                {
                    await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                    {
                        btnHexToAscii.Enabled = true;
                    })), EndInvoke);
                }
            });
        }

        private void BtnAsciiToHex_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(rtbInput.Text)) return;
            btnAsciiToHex.Enabled = false;

            var content = rtbInput.Text;
            _ = Task.Run(async () =>
            {
                string hexStr = StringByteUtils.BytesToString(Encoding.ASCII.GetBytes(content));
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    rtbOutput.AppendText(hexStr);
                    btnAsciiToHex.Enabled = true;
                })), EndInvoke);
            });
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            btnCount.Enabled = false;

            var content = rtbInput.Text;
            _ = Task.Run(async () =>
            {
                string Count = content.Length.ToString();
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    rtbOutput.AppendText(Count);
                    btnCount.Enabled = true;
                })), EndInvoke);
            });
        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(rtbInput.Text)) return;
            btnReverse.Enabled = false;

            var content = rtbInput.Text;
            _ = Task.Run(async () =>
            {
                content = new string(content.Reverse().ToArray());
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    rtbOutput.AppendText(content);
                    btnReverse.Enabled = true;
                })), EndInvoke);
            });
        }

        private void BtnUpper_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(rtbInput.Text)) return;
            btnUpper.Enabled = false;

            var content = rtbInput.Text;
            _ = Task.Run(async () =>
            {
                content = content.ToUpper();
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    rtbOutput.AppendText(content);
                    btnUpper.Enabled = true;
                })), EndInvoke);
            });
        }

        private void BtnLower_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(rtbInput.Text)) return;
            btnLower.Enabled = false;

            var content = rtbInput.Text;
            _ = Task.Run(async () =>
            {
                content = content.ToLower();
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    rtbOutput.AppendText(content);
                    btnLower.Enabled = true;
                })), EndInvoke);
            });
        }

        private void BtnMD5_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(rtbInput.Text)) return;
            btnMD5.Enabled = false;

            var content = rtbInput.Text;
            _ = Task.Run(async () =>
            {
                content = Utils.MD5.GetMD5Hash(content);
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    rtbOutput.AppendText(content);
                    btnMD5.Enabled = true;
                })), EndInvoke);
            });
        }
    }
}
