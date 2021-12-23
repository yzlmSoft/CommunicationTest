using CommunicationTest.Config.Parser;
using FastDeepCloner;

namespace CommunicationTest
{
    public partial class ParserConfig : Form
    {
        public ParserConfig()
        {
            InitializeComponent();
        }

        private async void ParserConfig_LoadAsync(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(HLType)))
            {
                cmbHLType.Items.Add(item);
            }
            var config = await Global.ParserConfig.GetAsync();
            foreach (var item in config.Item2)
            {
                if (item.Key == "HLType")
                {
                    Controls.Find($"cmb{item.Key}", true)[0].Text = item.Value;
                }
                else
                {
                    Controls.Find($"tb{item.Key}", true)[0].Text = item.Value;
                }
            }
            comboBox1.SelectedIndex = (int)config.Item1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Controls.Find("panel" + (comboBox1.SelectedIndex + 1), false)[0].BringToFront();
            }
        }

        private async void ParserConfig_FormClosingAsync(object sender, FormClosingEventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case (int)ParserType.TimeParser:
                    {
                        if (tbTime.Text == "")
                        {
                            MessageBox.Show("时间不为空");
                            e.Cancel = true;
                            return;
                        }
                    }
                    break;
                case (int)ParserType.HeadFootParser:
                    {
                        if (tbHFHead.Text == "" || tbHFFoot.Text == "")
                        {
                            MessageBox.Show("帧头帧尾不为空");
                            e.Cancel = true;
                            return;
                        }
                    }
                    break;
                case (int)ParserType.FootParser:
                    {
                        if (tbFFoot.Text == "")
                        {
                            MessageBox.Show("帧尾不为空");
                            e.Cancel = true;
                            return;
                        }
                    }
                    break;
                default:
                    break;
            }
            var config = await Global.ParserConfig.GetAsync();
            foreach (var item in config.Item2.Clone())
            {
                if (item.Key == "HLType")
                {
                    config.Item2[item.Key] = Controls.Find($"cmb{item.Key}", true)[0].Text;
                }
                else
                {
                    config.Item2[item.Key] = Controls.Find($"tb{item.Key}", true)[0].Text;
                }
            }
            await Global.ParserConfig.SetAsync((ParserType)comboBox1.SelectedIndex, config.Item2);
        }

        private void cmbHLType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHLLength.Visible = tbHLLength.Visible = cmbHLType.SelectedIndex == (int)HLType.输入固定长度;
        }
    }
}
