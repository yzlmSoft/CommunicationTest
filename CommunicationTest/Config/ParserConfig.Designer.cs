namespace CommunicationTest
{
    partial class ParserConfig
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbHFHead = new System.Windows.Forms.TextBox();
            this.tbHFFoot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbFFoot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbHLLength = new System.Windows.Forms.TextBox();
            this.lbHLLength = new System.Windows.Forms.Label();
            this.cmbHLType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHLHead = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "时间",
            "帧头长度",
            "帧头帧尾",
            "帧尾",
            "不使用解析器"});
            this.comboBox1.Location = new System.Drawing.Point(14, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbTime);
            this.panel1.Location = new System.Drawing.Point(15, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 100);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "分包时间:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(71, 38);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(78, 21);
            this.tbTime.TabIndex = 0;
            this.tbTime.Text = "20";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.tbHFHead);
            this.panel3.Controls.Add(this.tbHFFoot);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(15, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 100);
            this.panel3.TabIndex = 13;
            // 
            // tbHFHead
            // 
            this.tbHFHead.Location = new System.Drawing.Point(53, 18);
            this.tbHFHead.Name = "tbHFHead";
            this.tbHFHead.Size = new System.Drawing.Size(149, 21);
            this.tbHFHead.TabIndex = 0;
            // 
            // tbHFFoot
            // 
            this.tbHFFoot.Location = new System.Drawing.Point(53, 65);
            this.tbHFFoot.Name = "tbHFFoot";
            this.tbHFFoot.Size = new System.Drawing.Size(149, 21);
            this.tbHFFoot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "帧头:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "帧尾:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.tbFFoot);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(15, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 100);
            this.panel4.TabIndex = 14;
            // 
            // tbFFoot
            // 
            this.tbFFoot.Location = new System.Drawing.Point(48, 40);
            this.tbFFoot.Name = "tbFFoot";
            this.tbFFoot.Size = new System.Drawing.Size(149, 21);
            this.tbFFoot.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "帧尾:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbHLType);
            this.panel2.Controls.Add(this.tbHLHead);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbHLLength);
            this.panel2.Controls.Add(this.lbHLLength);
            this.panel2.Location = new System.Drawing.Point(15, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 100);
            this.panel2.TabIndex = 15;
            // 
            // tbHLLength
            // 
            this.tbHLLength.Location = new System.Drawing.Point(77, 66);
            this.tbHLLength.Name = "tbHLLength";
            this.tbHLLength.Size = new System.Drawing.Size(125, 21);
            this.tbHLLength.TabIndex = 0;
            // 
            // lbHLLength
            // 
            this.lbHLLength.AutoSize = true;
            this.lbHLLength.Location = new System.Drawing.Point(12, 69);
            this.lbHLLength.Name = "lbHLLength";
            this.lbHLLength.Size = new System.Drawing.Size(59, 12);
            this.lbHLLength.TabIndex = 1;
            this.lbHLLength.Text = "固定长度:";
            // 
            // cmbHLType
            // 
            this.cmbHLType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHLType.FormattingEnabled = true;
            this.cmbHLType.Location = new System.Drawing.Point(77, 40);
            this.cmbHLType.Name = "cmbHLType";
            this.cmbHLType.Size = new System.Drawing.Size(125, 20);
            this.cmbHLType.TabIndex = 2;
            this.cmbHLType.SelectedIndexChanged += new System.EventHandler(this.CmbHLType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "类型:";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(15, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 100);
            this.panel5.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "不使用任何分包器";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "帧头(可空):";
            // 
            // tbHLHead
            // 
            this.tbHLHead.Location = new System.Drawing.Point(77, 13);
            this.tbHLHead.Name = "tbHLHead";
            this.tbHLHead.Size = new System.Drawing.Size(125, 21);
            this.tbHLHead.TabIndex = 0;
            // 
            // ParserConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(234, 151);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ParserConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ParserConfig";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParserConfig_FormClosingAsync);
            this.Load += new System.EventHandler(this.ParserConfig_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbHFHead;
        private System.Windows.Forms.TextBox tbHFFoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbFFoot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbHLLength;
        private System.Windows.Forms.Label lbHLLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHLType;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHLHead;
        private System.Windows.Forms.Label label8;
    }
}