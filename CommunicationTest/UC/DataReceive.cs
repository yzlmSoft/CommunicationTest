using System.Text;
using System.Text.RegularExpressions;
using Utils;

namespace CommunicationTest.UC
{
    /// <summary>
    /// 数据接收文本框
    /// </summary>
    public partial class DataReceive : UserControl
    {
        private string? _path;
        private bool _isHighByteBefore = false;
        private DataEncode _EncodeType = DataEncode.Hex;
        internal delegate void DrawChartEventHandler(byte[] data);
        internal event DrawChartEventHandler? DrawChart;
        public DataReceive()
        {
            InitializeComponent();
        }

        #region 公有方法
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="data">字节数组</param>
        public async Task AddDataAsync(byte[] data, bool isSend = false)
        {
            switch (_EncodeType)
            {
                case DataEncode.Hex:
                    //16进制显示
                    var sb = new StringBuilder();
                    for (int i = 0; i < data.Length; i++)
                    {
                        sb.AppendFormat("{0:x2}" + " ", data[i]);
                    }
                    await AddContentAsync(sb.ToString().ToUpper(), isSend);
                    break;
                case DataEncode.ASCII:
                    //ASCII码显示
                    await AddContentAsync(Encoding.ASCII.GetString(data), isSend);
                    break;
                case DataEncode.UTF8:
                    //UTF8显示
                    await AddContentAsync(Encoding.UTF8.GetString(data), isSend);
                    break;
                case DataEncode.GB2312:
                    //GB2312显示
                    await AddContentAsync(Encoding.GetEncoding("GB2312").GetString(data), isSend);
                    break;
            }
            if (!isSend)
            {
                DrawChart?.Invoke(data);
            }
            await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
            {
                if (isSend)
                {
                    lbSCount.Text = (int.Parse(lbSCount.Text) + data.Length).ToString();
                }
                else
                {
                    lblCount.Text = (int.Parse(lblCount.Text) + data.Length).ToString();
                }
            })), EndInvoke);
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 添加文本内容
        /// </summary>
        /// <param name="content"></param>
        private async Task AddContentAsync(string content, bool isSend)
        {
            await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
            {
                string str = "";
                if (txtData.Text.Length > 0)
                {
                    str += "\r\n";
                }
                if (cbTime.Checked) str += DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + ": ";
                if (cbSend.Checked) str += isSend ? "发送->" : "接收<-"; else if (isSend) return;
                str += content;
                txtData.SuspendLayout();
                txtData.AppendText(str);

                if (txtData.Lines.Length > 2000)
                {
                    var temp = string.Join("\r\n", txtData.Lines.Skip(100));
                    txtData.Clear();
                    txtData.AppendText(temp);
                }
                txtData.ResumeLayout();

                if (cbAutoSave.Checked)
                {
                    string path = Path.Combine(Application.StartupPath, "History");
                    if (!string.IsNullOrEmpty(_path))
                    {
                        path = Path.Combine(path, _path);
                    }
                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                    byte[] rs = Encoding.GetEncoding("GB2312").GetBytes(str);
                    await using var fs = new FileStream(Path.Combine(path, $"{DateTime.Now:yyyyMMdd}.txt"), FileMode.Append, FileAccess.Write, FileShare.ReadWrite, 8, FileOptions.WriteThrough);
                    await fs.WriteAsync(rs);
                    await fs.FlushAsync();
                }
            })), EndInvoke);
        }

        private void LbCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((LinkLabel)sender).Text = "0";
        }

        private async void 保存接收数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "文本文件|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using var sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.Default);
                await sw.WriteAsync(txtData.Text);
                await sw.FlushAsync();
            }
        }
        #endregion

        #region 数据编码格式
        private void RbtnUTF8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUTF8.Checked)
            {
                _EncodeType = DataEncode.UTF8;
                绘制接收数据曲线ToolStripMenuItem.Enabled = true;
            }
        }

        private void RbtnGB2312_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGB2312.Checked)
            {
                _EncodeType = DataEncode.GB2312;
                绘制接收数据曲线ToolStripMenuItem.Enabled = true;
            }
        }

        private void RbtnASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnASCII.Checked)
            {
                _EncodeType = DataEncode.ASCII;
                绘制接收数据曲线ToolStripMenuItem.Enabled = true;
            }
        }

        private void RbtnHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHex.Checked)
            {
                _EncodeType = DataEncode.Hex;
                绘制接收数据曲线ToolStripMenuItem.Enabled = true;
            }
        }
        #endregion

        #region 菜单事件
        private void MS_Clear_Click(object sender, EventArgs e)
        {
            txtData.Clear();
            lblCount.Text = lbSCount.Text = "0";
        }

        private void CMS_Main_VisibleChanged(object sender, EventArgs e)
        {
            if (CMS_Main.Visible == true)
            {//菜单被显示
                string[] SelectData = txtData.SelectedText.TrimEnd().TrimStart().Split(' ');//获取选中部分文本
                foreach (string data in SelectData)
                {
                    if (Regex.IsMatch(data, "^[0-9A-Fa-f]+$"))
                    {
                        continue;
                    }
                    else
                    {
                        MS_ToInt.Enabled = false;
                        MS_ToUInt.Enabled = false;
                        MS_ToFloat.Enabled = false;
                        MS_ToDouble.Enabled = false;
                        return;
                    }
                }
                if (SelectData.Length == 2)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToUInt.Enabled = true;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 4)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToUInt.Enabled = true;
                    MS_ToFloat.Enabled = true;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 8)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToUInt.Enabled = true;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = true;
                }
                else
                {
                    MS_ToInt.Enabled = false;
                    MS_ToUInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
            }
            else
            {
                MS_ToInt.Enabled = false;
                MS_ToUInt.Enabled = false;
                MS_ToFloat.Enabled = false;
                MS_ToDouble.Enabled = false;
            }
        }
        #endregion

        #region 数值转换
        /// <summary>
        /// 2字节或4字节转换为整数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToInt_Click(object sender, EventArgs e)
        {
            byte[] IntByte = StringByteUtils.StringToBytes(txtData.SelectedText);
            switch (IntByte.Length)
            {
                case 2:
                    MessageBox.Show(StringByteUtils.ToInt16(IntByte, 0, _isHighByteBefore).ToString(), "整数值");
                    break;
                case 4:
                    MessageBox.Show(StringByteUtils.ToInt32(IntByte, 0, _isHighByteBefore).ToString(), "整数值");
                    break;
                default:
                    MessageBox.Show(StringByteUtils.ToInt64(IntByte, 0, _isHighByteBefore).ToString(), "整数值");
                    break;
            }
        }
        private void MS_ToUInt_Click(object sender, EventArgs e)
        {
            byte[] IntByte = StringByteUtils.StringToBytes(txtData.SelectedText);
            switch (IntByte.Length)
            {
                case 2:
                    MessageBox.Show(StringByteUtils.ToUInt16(IntByte, 0, _isHighByteBefore).ToString(), "无符号整数值");
                    break;
                case 4:
                    MessageBox.Show(StringByteUtils.ToUInt32(IntByte, 0, _isHighByteBefore).ToString(), "无符号整数值");
                    break;
                default:
                    MessageBox.Show(StringByteUtils.ToUInt64(IntByte, 0, _isHighByteBefore).ToString(), "无符号整数值");
                    break;
            }
        }
        /// <summary>
        /// 4字节转换为单精度浮点数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToFloat_Click(object sender, EventArgs e)
        {
            byte[] IntByte = StringByteUtils.StringToBytes(txtData.SelectedText);
            MessageBox.Show(StringByteUtils.ToSingle(IntByte, 0, _isHighByteBefore).ToString(), "单精度浮点数值");
        }
        /// <summary>
        /// 8字节转换为双精度浮点数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToDouble_Click(object sender, EventArgs e)
        {
            byte[] IntByte = StringByteUtils.StringToBytes(txtData.SelectedText);
            MessageBox.Show(StringByteUtils.ToDouble(IntByte, 0, _isHighByteBefore).ToString(), "双精度浮点数值");
        }
        #endregion

        private void CbAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoSave.Checked)
            {
                if (InputPath.Show(out var path) == DialogResult.OK)
                {
                    _path = path;
                    this.Parent.Text += $"-{_path}";
                }
                else
                {
                    cbAutoSave.Checked = false;
                }
            }
        }

        private void 绘制接收数据曲线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtData.SelectionLength > 0)
            {
                int index = 0;
                int lenth = 0;
                var selectIndex = txtData.SelectionStart;
                var firstCharIndexOfCurrentLine = txtData.GetFirstCharIndexOfCurrentLine();
                var selectLine = txtData.GetLineFromCharIndex(selectIndex);
                int start = firstCharIndexOfCurrentLine;
                if (cbTime.Checked) start += 25;
                if (cbSend.Checked) start += 4;
                switch (_EncodeType)
                {
                    case DataEncode.Hex:
                        index = (selectIndex - start) / 3;
                        if (txtData.SelectedText.IndexOf(' ') == 0) index++;
                        lenth = txtData.SelectedText.Replace(" ", "").Length / 2;
                        break;
                    case DataEncode.ASCII:
                        index = selectIndex - start;
                        lenth = txtData.SelectedText.Length;
                        break;
                    case DataEncode.UTF8:
                        break;
                    case DataEncode.GB2312:
                        break;
                    default:
                        break;
                }

                var chartSet = new ChartSet(_EncodeType, index, lenth);
                chartSet.ChartSetChanged += ChartSet_ChartSetChanged;
                chartSet.ShowDialog();
            }
            else
            {
                var chartSet = new ChartSet();
                chartSet.ChartSetChanged += ChartSet_ChartSetChanged;
                chartSet.ShowDialog();
            }
        }

        private void ChartSet_ChartSetChanged(int count, int startIndex, int lenth, DataType dataType, bool isLow, string formula, bool isASCII)
        {
            if (InputPath.Show(out var path) == DialogResult.OK)
            {
                var chart = new Chart(path, _EncodeType, count, startIndex, lenth, dataType, isLow, isASCII, formula);
                DrawChart += async data =>
                {
                    await chart.DrawChartAsync(data);
                };
                chart.FormClosed += (sender, e) =>
                {
                    DrawChart -= async data =>
                    {
                        await chart.DrawChartAsync(data);
                    };
                };
                chart.Show();
            }
        }

        private void 低字节在前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isHighByteBefore = !低字节在前ToolStripMenuItem.Checked;
        }
    }
}
