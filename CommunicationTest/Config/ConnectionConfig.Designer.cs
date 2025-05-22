namespace CommunicationTest
{
    partial class ConnectionConfig
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            controlParity = new ComboBox();
            controlStopBits = new ComboBox();
            controlDataBits = new ComboBox();
            controlBaudRate = new ComboBox();
            controlPortName = new ComboBox();
            cbRts = new CheckBox();
            cbDtr = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            controlTCPServerIP = new ComboBox();
            controlTCPServerPort = new NumericUpDown();
            label7 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            controlTCPClientIP = new TextBox();
            controlTCPClientPort = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)controlTCPServerPort).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)controlTCPClientPort).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(452, 287);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(controlParity);
            tabPage1.Controls.Add(controlStopBits);
            tabPage1.Controls.Add(controlDataBits);
            tabPage1.Controls.Add(controlBaudRate);
            tabPage1.Controls.Add(controlPortName);
            tabPage1.Controls.Add(cbRts);
            tabPage1.Controls.Add(cbDtr);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(444, 257);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SerialPort";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // controlParity
            // 
            controlParity.Anchor = AnchorStyles.None;
            controlParity.DropDownStyle = ComboBoxStyle.DropDownList;
            controlParity.FormattingEnabled = true;
            controlParity.Location = new Point(129, 158);
            controlParity.Name = "controlParity";
            controlParity.Size = new Size(226, 25);
            controlParity.TabIndex = 24;
            // 
            // controlStopBits
            // 
            controlStopBits.Anchor = AnchorStyles.None;
            controlStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            controlStopBits.FormattingEnabled = true;
            controlStopBits.Location = new Point(129, 132);
            controlStopBits.Name = "controlStopBits";
            controlStopBits.Size = new Size(226, 25);
            controlStopBits.TabIndex = 25;
            // 
            // controlDataBits
            // 
            controlDataBits.Anchor = AnchorStyles.None;
            controlDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            controlDataBits.FormattingEnabled = true;
            controlDataBits.Items.AddRange(new object[] { "8", "7", "6" });
            controlDataBits.Location = new Point(129, 106);
            controlDataBits.Name = "controlDataBits";
            controlDataBits.Size = new Size(226, 25);
            controlDataBits.TabIndex = 26;
            // 
            // controlBaudRate
            // 
            controlBaudRate.Anchor = AnchorStyles.None;
            controlBaudRate.FormattingEnabled = true;
            controlBaudRate.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "43000", "57000", "57600", "115200" });
            controlBaudRate.Location = new Point(129, 80);
            controlBaudRate.Name = "controlBaudRate";
            controlBaudRate.Size = new Size(226, 25);
            controlBaudRate.TabIndex = 27;
            // 
            // controlPortName
            // 
            controlPortName.Anchor = AnchorStyles.None;
            controlPortName.DropDownStyle = ComboBoxStyle.DropDownList;
            controlPortName.FormattingEnabled = true;
            controlPortName.Location = new Point(129, 54);
            controlPortName.Name = "controlPortName";
            controlPortName.Size = new Size(226, 25);
            controlPortName.TabIndex = 28;
            // 
            // cbRts
            // 
            cbRts.Anchor = AnchorStyles.None;
            cbRts.AutoSize = true;
            cbRts.Location = new Point(187, 184);
            cbRts.Name = "cbRts";
            cbRts.Size = new Size(49, 21);
            cbRts.TabIndex = 29;
            cbRts.Text = "RTS";
            cbRts.UseVisualStyleBackColor = true;
            // 
            // cbDtr
            // 
            cbDtr.Anchor = AnchorStyles.None;
            cbDtr.AutoSize = true;
            cbDtr.Location = new Point(129, 184);
            cbDtr.Name = "cbDtr";
            cbDtr.Size = new Size(51, 21);
            cbDtr.TabIndex = 29;
            cbDtr.Text = "DTR";
            cbDtr.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(76, 161);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 19;
            label6.Text = "校验位:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(76, 135);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 20;
            label5.Text = "停止位:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(76, 109);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 21;
            label4.Text = "数据位:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(76, 83);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 22;
            label3.Text = "波特率:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(76, 57);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 23;
            label2.Text = "串口号:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(controlTCPServerIP);
            tabPage2.Controls.Add(controlTCPServerPort);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(444, 257);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "TCPServer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // controlTCPServerIP
            // 
            controlTCPServerIP.Anchor = AnchorStyles.None;
            controlTCPServerIP.DropDownStyle = ComboBoxStyle.DropDownList;
            controlTCPServerIP.FormattingEnabled = true;
            controlTCPServerIP.Items.AddRange(new object[] { "Any" });
            controlTCPServerIP.Location = new Point(183, 105);
            controlTCPServerIP.Name = "controlTCPServerIP";
            controlTCPServerIP.Size = new Size(119, 25);
            controlTCPServerIP.TabIndex = 20;
            // 
            // controlTCPServerPort
            // 
            controlTCPServerPort.Anchor = AnchorStyles.None;
            controlTCPServerPort.Location = new Point(183, 131);
            controlTCPServerPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            controlTCPServerPort.Name = "controlTCPServerPort";
            controlTCPServerPort.Size = new Size(119, 23);
            controlTCPServerPort.TabIndex = 19;
            controlTCPServerPort.Value = new decimal(new int[] { 2756, 0, 0, 0 });
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(142, 133);
            label7.Name = "label7";
            label7.Size = new Size(35, 17);
            label7.TabIndex = 18;
            label7.Text = "端口:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(142, 108);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 17;
            label1.Text = "本地:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(controlTCPClientIP);
            tabPage3.Controls.Add(controlTCPClientPort);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(444, 257);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "TCPClient";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // controlTCPClientIP
            // 
            controlTCPClientIP.Anchor = AnchorStyles.None;
            controlTCPClientIP.Location = new Point(183, 104);
            controlTCPClientIP.Name = "controlTCPClientIP";
            controlTCPClientIP.Size = new Size(119, 23);
            controlTCPClientIP.TabIndex = 27;
            // 
            // controlTCPClientPort
            // 
            controlTCPClientPort.Anchor = AnchorStyles.None;
            controlTCPClientPort.Location = new Point(183, 131);
            controlTCPClientPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            controlTCPClientPort.Name = "controlTCPClientPort";
            controlTCPClientPort.Size = new Size(119, 23);
            controlTCPClientPort.TabIndex = 28;
            controlTCPClientPort.Value = new decimal(new int[] { 2756, 0, 0, 0 });
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(142, 133);
            label8.Name = "label8";
            label8.Size = new Size(35, 17);
            label8.TabIndex = 26;
            label8.Text = "端口:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(142, 107);
            label9.Name = "label9";
            label9.Size = new Size(35, 17);
            label9.TabIndex = 25;
            label9.Text = "远端:";
            // 
            // ConnectionConfig
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(452, 287);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(280, 220);
            Name = "ConnectionConfig";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConnectionConfig";
            FormClosing += ConnectionConfig_FormClosingAsync;
            Load += ConnectionConfig_LoadAsync;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)controlTCPServerPort).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)controlTCPClientPort).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox controlParity;
        private System.Windows.Forms.ComboBox controlStopBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox controlDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox controlBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox controlPortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox controlTCPServerIP;
        private System.Windows.Forms.NumericUpDown controlTCPServerPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox controlTCPClientIP;
        private System.Windows.Forms.NumericUpDown controlTCPClientPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbDtr;
        private System.Windows.Forms.CheckBox cbRts;
    }
}