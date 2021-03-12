using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace CommunicationTest
{
    public partial class CrcCalc : Form
    {
        public CrcCalc()
        {
            InitializeComponent();
        }

        private void btnCrc_Click(object sender, EventArgs e)
        {
            var value = tbIn.Text;
            byte[] data = cbIsAscii.Checked ? Encoding.Default.GetBytes(value) : StringByteUtils.StringToBytes(value);

            tbCrc16.Text = StringByteUtils.BytesToString(CRC.Crc16(data, data.Length));
            tbCrcc.Text = StringByteUtils.BytesToString(CRC.CRC16_C(data));
            tbUpdateCRC.Text = StringByteUtils.BytesToString(StringByteUtils.GetBytes(CRC.UpdateCRC(data, data.Length), true));
            tbGBcrc16.Text = $"##{value.Length.ToString().PadLeft(4, '0')}{value}{StringByteUtils.BytesToString(CRC.GBcrc16(data, data.Length)).Replace(" ", "")}";
            tbHBcrc16.Text = $"##{value.Length.ToString().PadLeft(4, '0')}{value}{StringByteUtils.BytesToString(CRC.HBcrc16(data, data.Length)).Replace(" ", "")}";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbCrc16.Text != "")
            {
                Clipboard.SetDataObject(tbCrc16.Text);
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbCrcc.Text != "")
            {
                Clipboard.SetDataObject(tbCrcc.Text);
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbUpdateCRC.Text != "")
            {
                Clipboard.SetDataObject(tbUpdateCRC.Text);
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbGBcrc16.Text != "")
            {
                Clipboard.SetDataObject(tbGBcrc16.Text);
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbHBcrc16.Text != "")
            {
                Clipboard.SetDataObject(tbHBcrc16.Text);
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject(toolTip1.GetToolTip((LinkLabel)sender));
        }
    }
}
