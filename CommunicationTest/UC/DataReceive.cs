using System.Text;
using System.Text.RegularExpressions;
using Utils;

namespace CommunicationTest
{
    /// <summary>
    /// 数据接收文本框
    /// </summary>
    public partial class DataReceive : UserControl
    {
        string? _path;
        int? _startIndex;
        int? _count;
        DataType? _dataType;
        bool? _isLow;
        bool _drawChart;
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
            switch (EncodeType)
            {
                case DataEncode.Hex:
                    //16进制显示
                    var sb = new StringBuilder();
                    for (int i = 0; i < data.Length; i++)
                    {
                        sb.AppendFormat("{0:x2}" + " ", data[i]);
                    }
                    await AddContentAsync(sb.ToString().ToUpper(), isSend);
                    if (_drawChart)
                    {
                        dynamic rs;
                        switch (_dataType)
                        {
                            case DataType.Float:
                                rs = StringByteUtils.ToSingle(data, (int)_startIndex!, (bool)!_isLow!);
                                break;
                            case DataType.int16:
                                rs = StringByteUtils.ToInt16(data, (int)_startIndex!, (bool)!_isLow!);
                                break;
                            case DataType.int32:
                                rs = StringByteUtils.ToInt32(data, (int)_startIndex!, (bool)!_isLow!);
                                break;
                            case DataType.int64:
                                rs = StringByteUtils.ToInt64(data, (int)_startIndex!, (bool)!_isLow!);
                                break;
                            default: return;
                        }
                        _ = await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                        {
                            if (realtimeChart1.Series[0].Count > _count)
                            {
                                realtimeChart1.Series[0].Delete(0);
                            }
                            var time = DateTime.Now;
                            realtimeChart1.Series[0].Add(time.ToOADate(), rs);
                        })), EndInvoke);
                    }
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
            await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
            {
                string str = "";
                if (cbxAutoLine.Checked && txtData.Text.Length > 0)
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
                    string path = Path.Combine(Environment.CurrentDirectory, "History");
                    if (!string.IsNullOrEmpty(_path))
                    {
                        path = Path.Combine(path, _path);
                    }
                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                    byte[] rs = Encoding.GetEncoding("GB2312").GetBytes(str);
                    using var fs = new FileStream(Path.Combine(path, $"{DateTime.Now:yyyyMMdd}.txt"), FileMode.Append, FileAccess.Write, FileShare.Read, rs.Length, FileOptions.WriteThrough);
                    fs.Write(rs, 0, rs.Length);
                    fs.Flush();
                }
            })), EndInvoke);
        }

        private void LbCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((LinkLabel)sender).Text = "0";
        }

        private void 保存接收数据ToolStripMenuItem_Click(object sender, EventArgs e)
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
                sw.Write(txtData.Text);
                sw.Flush();
            }
        }
        #endregion

        #region 数据编码格式
        private DataEncode EncodeType = DataEncode.Hex;

        private void RbtnUTF8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUTF8.Checked)
            {
                EncodeType = DataEncode.UTF8;
                绘制接收数据曲线ToolStripMenuItem.Enabled = false;
                _drawChart = false;
                splitContainer1.Panel2Collapsed = true;
            }
        }

        private void RbtnGB2312_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGB2312.Checked)
            {
                EncodeType = DataEncode.GB2312;
                绘制接收数据曲线ToolStripMenuItem.Enabled = false;
                _drawChart = false;
                splitContainer1.Panel2Collapsed = true;
            }
        }

        private void RbtnASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnASCII.Checked)
            {
                EncodeType = DataEncode.ASCII;
                绘制接收数据曲线ToolStripMenuItem.Enabled = false;
                _drawChart = false;
                splitContainer1.Panel2Collapsed = true;
            }
        }

        private void RbtnHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHex.Checked)
            {
                EncodeType = DataEncode.Hex;
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
                        MS_ToFloat.Enabled = false;
                        MS_ToDouble.Enabled = false;
                        return;
                    }
                }
                if (SelectData.Length == 2)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 4)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToFloat.Enabled = true;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 8)
                {
                    MS_ToInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = true;
                }
                else
                {
                    MS_ToInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
            }
            else
            {
                MS_ToInt.Enabled = false;
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
            if (IntByte.Length == 2)
            {
                MessageBox.Show(BitConverter.ToInt16(IntByte, 0).ToString(), "整数值");
            }
            else
            {
                MessageBox.Show(BitConverter.ToInt32(IntByte, 0).ToString(), "整数值");
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
            MessageBox.Show(BitConverter.ToSingle(IntByte, 0).ToString(), "单精度浮点数值");
        }
        /// <summary>
        /// 8字节转换为双精度浮点数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToDouble_Click(object sender, EventArgs e)
        {
            byte[] IntByte = StringByteUtils.StringToBytes(txtData.SelectedText);
            MessageBox.Show(BitConverter.ToDouble(IntByte, 0).ToString(), "双精度浮点数值");
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
            var chartSet = new ChartSet();
            chartSet.ChartSetChanged += ChartSet_ChartSetChanged;
            chartSet.ShowDialog();
        }

        private void ChartSet_ChartSetChanged(int startIndex, int count, DataType dataType, bool isLow)
        {
            realtimeChart1.Chart.Series[0].Clear();
            _startIndex = startIndex;
            _count = count;
            _dataType = dataType;
            _isLow = isLow;
            _drawChart = true;
            splitContainer1.Panel2Collapsed = false;
        }

        private void realtimeChart1_DoubleClick(object sender, EventArgs e)
        {
            _drawChart = false;
            splitContainer1.Panel2Collapsed = true;
        }
    }
}
