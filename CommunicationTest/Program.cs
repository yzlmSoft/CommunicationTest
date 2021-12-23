using System.Text;

namespace CommunicationTest
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (MessageBox.Show("是否导入为默认配置？\n若不是默认，下次打开将还原", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Global.DBPath = Global.DPath;
                    File.Copy(args[0], Global.DBPath, true);
                }
                else
                {
                    Global.DBPath = args[0];
                }
            }
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
