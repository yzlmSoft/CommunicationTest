namespace CommunicationTest
{
    enum DataType
    {
        Float,
        Int16,
        UInt16,
        Int32,
        UInt32,
        Int64,
        UInt64
    }
    internal partial class ChartSet : Form
    {
        private DataEncode _encodeType;
        private int _index;
        private int _lenth;

        public ChartSet()
        {
            InitializeComponent();
            cmbDataType.DataSource = Enum.GetValues(typeof(DataType));
        }

        public ChartSet(DataEncode encodeType, int index, int lenth) : this()
        {
            _encodeType = encodeType;
            _index = index;
            _lenth = lenth;
            cbASCII.Checked = !(lenth == 2 || lenth == 4);
            tbIndex.Text = index.ToString();
            tbLenth.Text = lenth.ToString();
        }

        internal delegate void ChartSetEventHandler(int count, int startIndex, int lenth, DataType dataType, bool isLow, string formula, bool isASCII);
        internal event ChartSetEventHandler? ChartSetChanged;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbDataType.SelectedIndex == -1) return;
            if (!int.TryParse(tbPointCount.Text, out var count)) return;
            if (!int.TryParse(tbIndex.Text, out var index)) return;
            int lenth = 0;
            if (cbASCII.Checked)
                if (!int.TryParse(tbLenth.Text, out lenth)) return;
            if (string.IsNullOrWhiteSpace(tbFormula.Text)) return;
            ChartSetChanged?.Invoke(count, index, lenth, (DataType)Enum.Parse(typeof(DataType), cmbDataType.SelectedItem.ToString()!), cbLow.Checked, tbFormula.Text, cbASCII.Checked);
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Help().ShowDialog();
        }

        private void cbASCII_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = tbLenth.Visible = cbASCII.Checked;
            cbLow.Visible = label5.Visible = cmbDataType.Visible = !cbASCII.Checked;
        }
    }
}
