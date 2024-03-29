﻿using CommunicationTest.Config.AutoReply;
using CommunicationTest.Config.Connection;
using CommunicationTest.Config.Parser;
using CommunicationTest.Config.SendList;

namespace CommunicationTest
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_LoadAsync(object sender, EventArgs e)
        {
            label2.Text = $"庆祝中国共产党诞生{DateTime.Now.Year - 1921}周年";
            _ = Task.Run(async () =>
            {
                Global.AutoReplyConfig = new AutoReplyConfigManager();
                Global.ConnectionConfig = new ConnectionConfigManager();
                Global.ParserConfig = new ParserConfigManager();
                Global.SendListConfig = new SendListConfigManager();
                await Task.Factory.FromAsync(BeginInvoke(new Action(() =>
                {
                    Close();
                })), EndInvoke);
            });
        }
    }
}
