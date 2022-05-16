namespace CommunicationTest
{
    public partial class InputPath : Form
    {
        public delegate void InputPathEventHandler(string strText);
        public InputPathEventHandler? InputPathHandler;
        public InputPath()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            InputPathHandler?.Invoke(tbPath.Text);
            DialogResult = DialogResult.OK;
        }

        public static DialogResult Show(out string path)
        {
            string strTemp = string.Empty;

            var inputDialog = new InputPath
            {
                InputPathHandler = (str) => { strTemp = str; }
            };

            DialogResult result = inputDialog.ShowDialog();
            path = strTemp;

            return result;
        }
    }
}
