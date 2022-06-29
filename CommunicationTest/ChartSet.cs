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
    public partial class ChartSet : Form
    {
        public ChartSet()
        {
            InitializeComponent();
            cmbDataType.DataSource = Enum.GetValues(typeof(DataType));
        }

        internal delegate void ChartSetEventHandler(int startIndex, int count, DataType dataType, bool isLow, string formula, bool isASCII);
        internal event ChartSetEventHandler? ChartSetChanged;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbDataType.SelectedIndex == -1) return;
            if (!int.TryParse(tbPointCount.Text, out var count)) return;
            if (!int.TryParse(tbIndex.Text, out var index)) return;
            if (string.IsNullOrWhiteSpace(tbFormula.Text)) return;
            ChartSetChanged?.Invoke(index, count, (DataType)Enum.Parse(typeof(DataType), cmbDataType.SelectedItem.ToString()!), cbLow.Checked, tbFormula.Text, cbASCII.Checked);
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Help().ShowDialog();
        }
    }
}
