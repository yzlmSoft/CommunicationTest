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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbRts = new System.Windows.Forms.CheckBox();
            this.cbDtr = new System.Windows.Forms.CheckBox();
            this.controlParity = new System.Windows.Forms.ComboBox();
            this.controlStopBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.controlDataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.controlBaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.controlPortName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.controlTCPServerIP = new System.Windows.Forms.ComboBox();
            this.controlTCPServerPort = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.controlTCPClientIP = new System.Windows.Forms.TextBox();
            this.controlTCPClientPort = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlTCPServerPort)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlTCPClientPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbRts);
            this.tabPage1.Controls.Add(this.cbDtr);
            this.tabPage1.Controls.Add(this.controlParity);
            this.tabPage1.Controls.Add(this.controlStopBits);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.controlDataBits);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.controlBaudRate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.controlPortName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SerialPort";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbRts
            // 
            this.cbRts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRts.AutoSize = true;
            this.cbRts.Location = new System.Drawing.Point(260, 215);
            this.cbRts.Name = "cbRts";
            this.cbRts.Size = new System.Drawing.Size(42, 16);
            this.cbRts.TabIndex = 29;
            this.cbRts.Text = "RTS";
            this.cbRts.UseVisualStyleBackColor = true;
            // 
            // cbDtr
            // 
            this.cbDtr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDtr.AutoSize = true;
            this.cbDtr.Location = new System.Drawing.Point(202, 215);
            this.cbDtr.Name = "cbDtr";
            this.cbDtr.Size = new System.Drawing.Size(42, 16);
            this.cbDtr.TabIndex = 29;
            this.cbDtr.Text = "DTR";
            this.cbDtr.UseVisualStyleBackColor = true;
            // 
            // controlParity
            // 
            this.controlParity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlParity.FormattingEnabled = true;
            this.controlParity.Location = new System.Drawing.Point(202, 189);
            this.controlParity.Name = "controlParity";
            this.controlParity.Size = new System.Drawing.Size(100, 20);
            this.controlParity.TabIndex = 24;
            // 
            // controlStopBits
            // 
            this.controlStopBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlStopBits.FormattingEnabled = true;
            this.controlStopBits.Location = new System.Drawing.Point(202, 163);
            this.controlStopBits.Name = "controlStopBits";
            this.controlStopBits.Size = new System.Drawing.Size(100, 20);
            this.controlStopBits.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "校验位";
            // 
            // controlDataBits
            // 
            this.controlDataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlDataBits.FormattingEnabled = true;
            this.controlDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.controlDataBits.Location = new System.Drawing.Point(202, 137);
            this.controlDataBits.Name = "controlDataBits";
            this.controlDataBits.Size = new System.Drawing.Size(100, 20);
            this.controlDataBits.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "停止位";
            // 
            // controlBaudRate
            // 
            this.controlBaudRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlBaudRate.FormattingEnabled = true;
            this.controlBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "57000",
            "57600",
            "115200"});
            this.controlBaudRate.Location = new System.Drawing.Point(202, 111);
            this.controlBaudRate.Name = "controlBaudRate";
            this.controlBaudRate.Size = new System.Drawing.Size(100, 20);
            this.controlBaudRate.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "数据位";
            // 
            // controlPortName
            // 
            this.controlPortName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlPortName.FormattingEnabled = true;
            this.controlPortName.Location = new System.Drawing.Point(202, 85);
            this.controlPortName.Name = "controlPortName";
            this.controlPortName.Size = new System.Drawing.Size(100, 20);
            this.controlPortName.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "波特率";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "串口号";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.controlTCPServerIP);
            this.tabPage2.Controls.Add(this.controlTCPServerPort);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCPServer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // controlTCPServerIP
            // 
            this.controlTCPServerIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlTCPServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlTCPServerIP.FormattingEnabled = true;
            this.controlTCPServerIP.Items.AddRange(new object[] {
            "Any"});
            this.controlTCPServerIP.Location = new System.Drawing.Point(189, 124);
            this.controlTCPServerIP.Name = "controlTCPServerIP";
            this.controlTCPServerIP.Size = new System.Drawing.Size(119, 20);
            this.controlTCPServerIP.TabIndex = 20;
            // 
            // controlTCPServerPort
            // 
            this.controlTCPServerPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlTCPServerPort.Location = new System.Drawing.Point(189, 150);
            this.controlTCPServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.controlTCPServerPort.Name = "controlTCPServerPort";
            this.controlTCPServerPort.Size = new System.Drawing.Size(119, 21);
            this.controlTCPServerPort.TabIndex = 19;
            this.controlTCPServerPort.Value = new decimal(new int[] {
            2756,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "端口:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "本地:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.controlTCPClientIP);
            this.tabPage3.Controls.Add(this.controlTCPClientPort);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(456, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TCPClient";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // controlTCPClientIP
            // 
            this.controlTCPClientIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlTCPClientIP.Location = new System.Drawing.Point(189, 123);
            this.controlTCPClientIP.Name = "controlTCPClientIP";
            this.controlTCPClientIP.Size = new System.Drawing.Size(119, 21);
            this.controlTCPClientIP.TabIndex = 27;
            // 
            // controlTCPClientPort
            // 
            this.controlTCPClientPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlTCPClientPort.Location = new System.Drawing.Point(189, 150);
            this.controlTCPClientPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.controlTCPClientPort.Name = "controlTCPClientPort";
            this.controlTCPClientPort.Size = new System.Drawing.Size(119, 21);
            this.controlTCPClientPort.TabIndex = 28;
            this.controlTCPClientPort.Value = new decimal(new int[] {
            2756,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "端口:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "远端:";
            // 
            // ConnectionConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(280, 220);
            this.Name = "ConnectionConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConnectionConfig";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionConfig_FormClosingAsync);
            this.Load += new System.EventHandler(this.ConnectionConfig_LoadAsync);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlTCPServerPort)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlTCPClientPort)).EndInit();
            this.ResumeLayout(false);

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