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

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cbTopMost.Checked;
        }

        private void btnHexToFloat_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            if (rtbInput.Text == null || rtbInput.Text == "") return;
            btnHexToFloat.Enabled = false;

            string[] splitStr = rtbInput.Text.Split('\n');

            Thread thread = new Thread(CalcHexToFloat);
            thread.IsBackground = true;
            thread.Start(splitStr);
        }

        private void CalcHexToFloat(object obj)
        {
            string[] splitStr = (string[])obj;
            StringBuilder stringBuilder = new StringBuilder();
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
                stringBuilder.Append("\n");
            }
            this.Invoke((EventHandler)delegate
            {
                rtbOutput.AppendText(stringBuilder.ToString());
                btnHexToFloat.Enabled = true;
            });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFloatToHex_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            if (rtbInput.Text == null || rtbInput.Text == "") return;
            btnFloatToHex.Enabled = false;

            string[] splitStr = rtbInput.Text.Split('\n');

            Thread thread = new Thread(CalcFloatToHex);
            thread.IsBackground = true;
            thread.Start(splitStr);
        }

        private void CalcFloatToHex(object obj)
        {
            string[] splitStr = (string[])obj;
            StringBuilder stringBuilder = new StringBuilder();
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
                stringBuilder.Append("\n");
            }
            this.Invoke((EventHandler)delegate
            {
                rtbOutput.AppendText(stringBuilder.ToString());
                btnFloatToHex.Enabled = true;
            });
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            rtbInput.Text = "";
        }

        private void btnHexToAscii_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            if (rtbInput.Text == null || rtbInput.Text == "") return;
            btnHexToAscii.Enabled = false;

            Thread thread = new Thread(CalcHexToAscii);
            thread.IsBackground = true;
            thread.Start(rtbInput.Text);
        }

        private void CalcHexToAscii(object obj)
        {
            string hexStr = (string)obj;
            try
            {
                string str = Encoding.ASCII.GetString(StringByteUtils.StringToBytes(hexStr));
                this.Invoke((EventHandler)delegate
                {
                    rtbOutput.AppendText(str);
                    btnHexToAscii.Enabled = true;
                });
            }
            catch
            {
                MessageBox.Show("请正确输入需要转换的内容");
                this.Invoke((EventHandler)delegate
                {
                    btnHexToAscii.Enabled = true;
                });
            }
        }

        private void btnAsciiToHex_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            if (rtbInput.Text == null || rtbInput.Text == "") return;
            btnAsciiToHex.Enabled = false;

            Thread thread = new Thread(CalcAsciiToHex);
            thread.IsBackground = true;
            thread.Start(rtbInput.Text);
        }

        private void CalcAsciiToHex(object obj)
        {
            string Str = (string)obj;
            string hexStr = StringByteUtils.BytesToString(Encoding.ASCII.GetBytes(Str));
            this.Invoke((EventHandler)delegate
            {
                rtbOutput.AppendText(hexStr);
                btnAsciiToHex.Enabled = true;
            });
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            btnCount.Enabled = false;
            Thread thread = new Thread(CalcCount);
            thread.IsBackground = true;
            thread.Start(rtbInput.Text);
        }

        private void CalcCount(object obj)
        {
            string content = (string)obj;
            string Count = content.Length.ToString();
            this.Invoke((EventHandler)delegate
            {
                rtbOutput.AppendText(Count);
                btnCount.Enabled = true;
            });
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            if (rtbInput.Text == null || rtbInput.Text == "") return;
            btnReverse.Enabled = false;

            Thread thread = new Thread(CalcReverse);
            thread.IsBackground = true;
            thread.Start(rtbInput.Text);
        }

        private void CalcReverse(object obj)
        {
            string content = (string)obj;
            content = new string(content.Reverse().ToArray());
            this.Invoke((EventHandler)delegate
            {
                rtbOutput.AppendText(content);
                btnReverse.Enabled = true;
            });
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            if (rtbInput.Text == null || rtbInput.Text == "") return;
            btnUpper.Enabled = false;

            Thread thread = new Thread(CalcUpper);
            thread.IsBackground = true;
            thread.Start(rtbInput.Text);
        }

        private void CalcUpper(object obj)
        {
            string content = (string)obj;
            content = content.ToUpper();
            this.Invoke((EventHandler)delegate
            {
                rtbOutput.AppendText(content);
                btnUpper.Enabled = true;
            });
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            if (rtbInput.Text == null || rtbInput.Text == "") return;
            btnLower.Enabled = false;

            Thread thread = new Thread(CalcLower);
            thread.IsBackground = true;
            thread.Start(rtbInput.Text);
        }

        private void CalcLower(object obj)
        {
            string content = (string)obj;
            content = content.ToLower();
            this.Invoke((EventHandler)delegate
            {
                rtbOutput.AppendText(content);
                btnLower.Enabled = true;
            });
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            if (rtbInput.Text == null || rtbInput.Text == "") return;
            btnMD5.Enabled = false;

            Thread thread = new Thread(CalcMD5);
            thread.IsBackground = true;
            thread.Start(rtbInput.Text);
        }

        private void CalcMD5(object obj)
        {
            string content = (string)obj;
            content = Utils.MD5.GetMD5Hash(content);
            this.Invoke((EventHandler)delegate
            {
                rtbOutput.AppendText(content);
                btnMD5.Enabled = true;
            });
        }
    }
}
