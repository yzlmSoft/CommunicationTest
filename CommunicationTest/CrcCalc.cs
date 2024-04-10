using System.Text;
using Utils;

namespace CommunicationTest
{
    public partial class CrcCalc : Form
    {
        public CrcCalc()
        {
            InitializeComponent();
        }

        private void BtnCrc_Click(object sender, EventArgs e)
        {
            var value = tbIn.Text;
            byte[] data = cbIsAscii.Checked ? Encoding.Default.GetBytes(value) : StringByteUtils.StringToBytes(value);

            tbCrc16.Text = StringByteUtils.BytesToString(CRC.Crc16(data, data.Length));
            tbCrc_r.Text = StringByteUtils.BytesToString(CRC.CRC16_R(data));
            tbUpdateCRC.Text = StringByteUtils.BytesToString(CRC.UpdateCRC(data));
            tbGBcrc16.Text = $"##{value.Length.ToString().PadLeft(4, '0')}{value}{StringByteUtils.BytesToString(CRC.GBcrc16(data, data.Length)).Replace(" ", "")}";
            tbHBcrc16.Text = $"##{value.Length.ToString().PadLeft(4, '0')}{value}{StringByteUtils.BytesToString(CRC.HBcrc16(data, data.Length)).Replace(" ", "")}";
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbCrc16.Text != "")
            {
                Clipboard.SetDataObject(tbCrc16.Text);
            }
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbCrc_r.Text != "")
            {
                Clipboard.SetDataObject(tbCrc_r.Text);
            }
        }

        private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbUpdateCRC.Text != "")
            {
                Clipboard.SetDataObject(tbUpdateCRC.Text);
            }
        }

        private void LinkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbGBcrc16.Text != "")
            {
                Clipboard.SetDataObject(tbGBcrc16.Text);
            }
        }

        private void LinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbHBcrc16.Text != "")
            {
                Clipboard.SetDataObject(tbHBcrc16.Text);
            }
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject(toolTip1.GetToolTip((LinkLabel)sender));
        }
    }
}
