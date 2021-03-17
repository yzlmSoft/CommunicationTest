
namespace CommunicationTest
{
    partial class CrcCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIn = new System.Windows.Forms.TextBox();
            this.cbIsAscii = new System.Windows.Forms.CheckBox();
            this.tbCrc16 = new System.Windows.Forms.TextBox();
            this.btnCrc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCrcc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUpdateCRC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGBcrc16 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHBcrc16 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入:";
            // 
            // tbIn
            // 
            this.tbIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIn.Location = new System.Drawing.Point(156, 26);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(298, 23);
            this.tbIn.TabIndex = 1;
            // 
            // cbIsAscii
            // 
            this.cbIsAscii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIsAscii.AutoSize = true;
            this.cbIsAscii.Location = new System.Drawing.Point(460, 28);
            this.cbIsAscii.Name = "cbIsAscii";
            this.cbIsAscii.Size = new System.Drawing.Size(106, 21);
            this.cbIsAscii.TabIndex = 2;
            this.cbIsAscii.Text = "输入的是ASCII";
            this.cbIsAscii.UseVisualStyleBackColor = true;
            // 
            // tbCrc16
            // 
            this.tbCrc16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCrc16.Location = new System.Drawing.Point(156, 55);
            this.tbCrc16.Name = "tbCrc16";
            this.tbCrc16.Size = new System.Drawing.Size(298, 23);
            this.tbCrc16.TabIndex = 3;
            // 
            // btnCrc
            // 
            this.btnCrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrc.Location = new System.Drawing.Point(177, 214);
            this.btnCrc.Name = "btnCrc";
            this.btnCrc.Size = new System.Drawing.Size(218, 23);
            this.btnCrc.TabIndex = 4;
            this.btnCrc.Text = "计算";
            this.btnCrc.UseVisualStyleBackColor = true;
            this.btnCrc.Click += new System.EventHandler(this.btnCrc_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modbus_Crc16:";
            // 
            // tbCrcc
            // 
            this.tbCrcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCrcc.Location = new System.Drawing.Point(156, 84);
            this.tbCrcc.Name = "tbCrcc";
            this.tbCrcc.Size = new System.Drawing.Size(298, 23);
            this.tbCrcc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crc16_C:";
            // 
            // tbUpdateCRC
            // 
            this.tbUpdateCRC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUpdateCRC.Location = new System.Drawing.Point(156, 113);
            this.tbUpdateCRC.Name = "tbUpdateCRC";
            this.tbUpdateCRC.Size = new System.Drawing.Size(298, 23);
            this.tbUpdateCRC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "UpdateCRC:";
            // 
            // tbGBcrc16
            // 
            this.tbGBcrc16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGBcrc16.Location = new System.Drawing.Point(156, 142);
            this.tbGBcrc16.Name = "tbGBcrc16";
            this.tbGBcrc16.Size = new System.Drawing.Size(298, 23);
            this.tbGBcrc16.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "GBcrc16:";
            // 
            // tbHBcrc16
            // 
            this.tbHBcrc16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHBcrc16.Location = new System.Drawing.Point(156, 171);
            this.tbHBcrc16.Name = "tbHBcrc16";
            this.tbHBcrc16.Size = new System.Drawing.Size(298, 23);
            this.tbHBcrc16.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "HBcrc16:";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "使用代码";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(522, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "复制代码";
            this.toolTip1.SetToolTip(this.linkLabel1, "StringByteUtils.BytesToString(CRC.Crc16(data, data.Length));");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(522, 87);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 17);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "复制代码";
            this.toolTip1.SetToolTip(this.linkLabel2, "StringByteUtils.BytesToString(CRC.CRC16_C(data));");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(522, 116);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(56, 17);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "复制代码";
            this.toolTip1.SetToolTip(this.linkLabel3, "StringByteUtils.BytesToString(StringByteUtils.GetBytes(CRC.UpdateCRC(data, data.L" +
        "ength), true));");
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(522, 145);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(56, 17);
            this.linkLabel4.TabIndex = 6;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "复制代码";
            this.toolTip1.SetToolTip(this.linkLabel4, "$\"##{value.Length.ToString().PadLeft(4, \'0\')}{value}{StringByteUtils.BytesToStrin" +
        "g(CRC.GBcrc16(data, data.Length)).Replace(\" \", \"\")}\";");
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(522, 174);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(56, 17);
            this.linkLabel5.TabIndex = 6;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "复制代码";
            this.toolTip1.SetToolTip(this.linkLabel5, "$\"##{value.Length.ToString().PadLeft(4, \'0\')}{value}{StringByteUtils.BytesToStrin" +
        "g(CRC.HBcrc16(data, data.Length)).Replace(\" \", \"\")}\";");
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(460, 58);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(56, 17);
            this.linkLabel6.TabIndex = 7;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "复制结果";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(460, 87);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(56, 17);
            this.linkLabel7.TabIndex = 7;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "复制结果";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(460, 116);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(56, 17);
            this.linkLabel8.TabIndex = 7;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "复制结果";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabel9
            // 
            this.linkLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(460, 145);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(56, 17);
            this.linkLabel9.TabIndex = 7;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "复制结果";
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            // 
            // linkLabel10
            // 
            this.linkLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(460, 174);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(56, 17);
            this.linkLabel10.TabIndex = 7;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "复制结果";
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
            // 
            // CrcCalc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Controls.Add(this.tbHBcrc16);
            this.Controls.Add(this.tbGBcrc16);
            this.Controls.Add(this.tbUpdateCRC);
            this.Controls.Add(this.tbCrcc);
            this.Controls.Add(this.tbCrc16);
            this.Controls.Add(this.tbIn);
            this.Controls.Add(this.linkLabel10);
            this.Controls.Add(this.linkLabel9);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrc);
            this.Controls.Add(this.cbIsAscii);
            this.Controls.Add(this.label1);
            this.Name = "CrcCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrcCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.CheckBox cbIsAscii;
        private System.Windows.Forms.TextBox tbCrc16;
        private System.Windows.Forms.Button btnCrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHBcrc16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCrcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUpdateCRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGBcrc16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel10;
    }
}