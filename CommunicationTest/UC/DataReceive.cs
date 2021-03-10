using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using Utils;
using System.Threading;

namespace CommunicationTest
{
    /// <summary>
    /// 数据接收文本框
    /// </summary>
    public partial class DataReceive : UserControl
    {
        public DataReceive()
        {
            InitializeComponent();
        }

        #region 公有方法
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="data">字节数组</param>
        public async Task AddDataAsync(byte[] data)
        {
            switch (EncodeType)
            {
                case DataEncode.Hex:
                    //16进制显示
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < data.Length; i++)
                    {
                        sb.AppendFormat("{0:x2}" + " ", data[i]);
                    }
                    await AddContentAsync(sb.ToString().ToUpper());
                    break;
                case DataEncode.ASCII:
                    //ASCII码显示
                    await AddContentAsync(new ASCIIEncoding().GetString(data));
                    break;
                case DataEncode.UTF8:
                    //UTF8显示
                    await AddContentAsync(new UTF8Encoding().GetString(data));
                    break;
                case DataEncode.GB2312:
                    //GB2312显示
                    await AddContentAsync(Encoding.GetEncoding("GB2312").GetString(data));
                    break;
            }
            await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
            {
                lblCount.Text = (int.Parse(lblCount.Text) + data.Length).ToString();
            })), EndInvoke);
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 添加文本内容
        /// </summary>
        /// <param name="content"></param>
        private async Task AddContentAsync(string content)
        {
            await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
            {
                string str = "";
                if (cbxAutoLine.Checked && txtData.Text.Length > 0)
                {
                    str += "\r\n";
                }
                if (cbTime.Checked) str += DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + ": ";
                str += content;
                txtData.AppendText(str);
                if (cbAutoSave.Checked)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "/History/";
                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                    byte[] rs = Encoding.ASCII.GetBytes(str);
                    using (FileStream fs = new FileStream(path + DateTime.Now.ToString("yyyyMMdd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.None, rs.Length, FileOptions.WriteThrough))
                    {
                        fs.Write(rs, 0, rs.Length);
                        fs.Flush();
                    }
                }
            })), EndInvoke);
        }

        private void lblCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblCount.Text = "0";
        }

        private void 保存接收数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var thread = new Thread(() =>
            //{
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "文本文件|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = saveFileDialog.FileName;
                    using (StreamWriter sw = new StreamWriter(fName, false, Encoding.Default))
                    {
                        sw.Write(txtData.Text);
                    }
                }
            //});
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
        }
        #endregion

        #region 数据编码格式
        private DataEncode EncodeType = DataEncode.Hex;

        private void rbtnUTF8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUTF8.Checked)
            {
                EncodeType = DataEncode.UTF8;
            }
        }

        private void rbtnGB2312_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGB2312.Checked)
            {
                EncodeType = DataEncode.GB2312;
            }
        }

        private void rbtnASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnASCII.Checked)
            {
                EncodeType = DataEncode.ASCII;
            }
        }

        private void rbtnHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHex.Checked)
            {
                EncodeType = DataEncode.Hex;
            }
        }
        #endregion

        #region 菜单事件
        private void MS_Clear_Click(object sender, EventArgs e)
        {
            txtData.Clear();
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
    }
}
