namespace CommunicationTest
{
    enum DataType
    {
        Float,
        int16,
        int32,
        int64
    }
    public partial class ChartSet : Form
    {
        public ChartSet()
        {
            InitializeComponent();
            cmbDataType.DataSource = Enum.GetValues(typeof(DataType));
        }

        internal delegate void ChartSetEventHandler(int startIndex, int count, DataType dataType, bool isLow);
        internal event ChartSetEventHandler? ChartSetChanged;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbDataType.SelectedIndex == -1) return;
            if (!int.TryParse(tbPointCount.Text, out var count)) return;
            if (!int.TryParse(tbIndex.Text, out var index)) return;
            ChartSetChanged?.Invoke(index, count, (DataType)Enum.Parse(typeof(DataType), cmbDataType.SelectedItem.ToString()!), cbLow.Checked);
            Close();
        }
    }
}
