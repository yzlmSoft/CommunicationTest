
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tbIn = new TextBox();
            cbIsAscii = new CheckBox();
            tbCrc16 = new TextBox();
            btnCrc = new Button();
            label2 = new Label();
            tbCrc_r = new TextBox();
            label3 = new Label();
            tbUpdateCRC = new TextBox();
            label4 = new Label();
            tbGBcrc16 = new TextBox();
            label5 = new Label();
            tbHBcrc16 = new TextBox();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            linkLabel7 = new LinkLabel();
            linkLabel8 = new LinkLabel();
            linkLabel9 = new LinkLabel();
            linkLabel10 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(115, 29);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 0;
            label1.Text = "输入:";
            // 
            // tbIn
            // 
            tbIn.Anchor = AnchorStyles.None;
            tbIn.Location = new Point(156, 26);
            tbIn.Name = "tbIn";
            tbIn.Size = new Size(298, 23);
            tbIn.TabIndex = 1;
            // 
            // cbIsAscii
            // 
            cbIsAscii.Anchor = AnchorStyles.None;
            cbIsAscii.AutoSize = true;
            cbIsAscii.Location = new Point(460, 28);
            cbIsAscii.Name = "cbIsAscii";
            cbIsAscii.Size = new Size(106, 21);
            cbIsAscii.TabIndex = 2;
            cbIsAscii.Text = "输入的是ASCII";
            cbIsAscii.UseVisualStyleBackColor = true;
            // 
            // tbCrc16
            // 
            tbCrc16.Anchor = AnchorStyles.None;
            tbCrc16.Location = new Point(156, 55);
            tbCrc16.Name = "tbCrc16";
            tbCrc16.Size = new Size(298, 23);
            tbCrc16.TabIndex = 3;
            // 
            // btnCrc
            // 
            btnCrc.Anchor = AnchorStyles.None;
            btnCrc.Location = new Point(177, 214);
            btnCrc.Name = "btnCrc";
            btnCrc.Size = new Size(218, 23);
            btnCrc.TabIndex = 4;
            btnCrc.Text = "计算";
            btnCrc.UseVisualStyleBackColor = true;
            btnCrc.Click += BtnCrc_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(52, 58);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 5;
            label2.Text = "Modbus_Crc16:";
            // 
            // tbCrc_r
            // 
            tbCrc_r.Anchor = AnchorStyles.None;
            tbCrc_r.Location = new Point(156, 84);
            tbCrc_r.Name = "tbCrc_r";
            tbCrc_r.Size = new Size(298, 23);
            tbCrc_r.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(93, 87);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 5;
            label3.Text = "Crc16_R:";
            // 
            // tbUpdateCRC
            // 
            tbUpdateCRC.Anchor = AnchorStyles.None;
            tbUpdateCRC.Location = new Point(156, 113);
            tbUpdateCRC.Name = "tbUpdateCRC";
            tbUpdateCRC.Size = new Size(298, 23);
            tbUpdateCRC.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(72, 116);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 5;
            label4.Text = "UpdateCRC:";
            // 
            // tbGBcrc16
            // 
            tbGBcrc16.Anchor = AnchorStyles.None;
            tbGBcrc16.Location = new Point(156, 142);
            tbGBcrc16.Name = "tbGBcrc16";
            tbGBcrc16.Size = new Size(298, 23);
            tbGBcrc16.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(91, 145);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 5;
            label5.Text = "GBcrc16:";
            // 
            // tbHBcrc16
            // 
            tbHBcrc16.Anchor = AnchorStyles.None;
            tbHBcrc16.Location = new Point(156, 171);
            tbHBcrc16.Name = "tbHBcrc16";
            tbHBcrc16.Size = new Size(298, 23);
            tbHBcrc16.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(91, 174);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 5;
            label6.Text = "HBcrc16:";
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "使用代码";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(522, 58);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 17);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "复制代码";
            toolTip1.SetToolTip(linkLabel1, "StringByteUtils.BytesToString(CRC.Crc16(data, data.Length));");
            linkLabel1.LinkClicked += LinkLabel_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(522, 87);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(56, 17);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "复制代码";
            toolTip1.SetToolTip(linkLabel2, "StringByteUtils.BytesToString(CRC.CRC16_R(data));");
            linkLabel2.LinkClicked += LinkLabel_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.Anchor = AnchorStyles.None;
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(522, 116);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(56, 17);
            linkLabel3.TabIndex = 6;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "复制代码";
            toolTip1.SetToolTip(linkLabel3, "StringByteUtils.BytesToString(CRC.UpdateCRC(data));");
            linkLabel3.LinkClicked += LinkLabel_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.Anchor = AnchorStyles.None;
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(522, 145);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(56, 17);
            linkLabel4.TabIndex = 6;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "复制代码";
            toolTip1.SetToolTip(linkLabel4, "$\"##{value.Length.ToString().PadLeft(4, '0')}{value}{StringByteUtils.BytesToString(CRC.GBcrc16(data, data.Length)).Replace(\" \", \"\")}\";");
            linkLabel4.LinkClicked += LinkLabel_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.Anchor = AnchorStyles.None;
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new Point(522, 174);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(56, 17);
            linkLabel5.TabIndex = 6;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "复制代码";
            toolTip1.SetToolTip(linkLabel5, "$\"##{value.Length.ToString().PadLeft(4, '0')}{value}{StringByteUtils.BytesToString(CRC.HBcrc16(data, data.Length)).Replace(\" \", \"\")}\";");
            linkLabel5.LinkClicked += LinkLabel_LinkClicked;
            // 
            // linkLabel6
            // 
            linkLabel6.Anchor = AnchorStyles.None;
            linkLabel6.AutoSize = true;
            linkLabel6.Location = new Point(460, 58);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(56, 17);
            linkLabel6.TabIndex = 7;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "复制结果";
            linkLabel6.LinkClicked += LinkLabel6_LinkClicked;
            // 
            // linkLabel7
            // 
            linkLabel7.Anchor = AnchorStyles.None;
            linkLabel7.AutoSize = true;
            linkLabel7.Location = new Point(460, 87);
            linkLabel7.Name = "linkLabel7";
            linkLabel7.Size = new Size(56, 17);
            linkLabel7.TabIndex = 7;
            linkLabel7.TabStop = true;
            linkLabel7.Text = "复制结果";
            linkLabel7.LinkClicked += LinkLabel7_LinkClicked;
            // 
            // linkLabel8
            // 
            linkLabel8.Anchor = AnchorStyles.None;
            linkLabel8.AutoSize = true;
            linkLabel8.Location = new Point(460, 116);
            linkLabel8.Name = "linkLabel8";
            linkLabel8.Size = new Size(56, 17);
            linkLabel8.TabIndex = 7;
            linkLabel8.TabStop = true;
            linkLabel8.Text = "复制结果";
            linkLabel8.LinkClicked += LinkLabel8_LinkClicked;
            // 
            // linkLabel9
            // 
            linkLabel9.Anchor = AnchorStyles.None;
            linkLabel9.AutoSize = true;
            linkLabel9.Location = new Point(460, 145);
            linkLabel9.Name = "linkLabel9";
            linkLabel9.Size = new Size(56, 17);
            linkLabel9.TabIndex = 7;
            linkLabel9.TabStop = true;
            linkLabel9.Text = "复制结果";
            linkLabel9.LinkClicked += LinkLabel9_LinkClicked;
            // 
            // linkLabel10
            // 
            linkLabel10.Anchor = AnchorStyles.None;
            linkLabel10.AutoSize = true;
            linkLabel10.Location = new Point(460, 174);
            linkLabel10.Name = "linkLabel10";
            linkLabel10.Size = new Size(56, 17);
            linkLabel10.TabIndex = 7;
            linkLabel10.TabStop = true;
            linkLabel10.Text = "复制结果";
            linkLabel10.LinkClicked += LinkLabel10_LinkClicked;
            // 
            // CrcCalc
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(601, 261);
            Controls.Add(tbHBcrc16);
            Controls.Add(tbGBcrc16);
            Controls.Add(tbUpdateCRC);
            Controls.Add(tbCrc_r);
            Controls.Add(tbCrc16);
            Controls.Add(tbIn);
            Controls.Add(linkLabel10);
            Controls.Add(linkLabel9);
            Controls.Add(linkLabel8);
            Controls.Add(linkLabel7);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCrc);
            Controls.Add(cbIsAscii);
            Controls.Add(label1);
            Name = "CrcCalc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrcCalc";
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox tbCrc_r;
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