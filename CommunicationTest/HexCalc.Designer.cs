namespace CommunicationTest
{
    partial class HexCalc
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexCalc));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnAsciiToHex = new System.Windows.Forms.Button();
            this.btnHexToAscii = new System.Windows.Forms.Button();
            this.btnFloatToHex = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSplit = new System.Windows.Forms.TextBox();
            this.cbTopMost = new System.Windows.Forms.CheckBox();
            this.btnHexToFloat = new System.Windows.Forms.Button();
            this.cbHB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnMD5);
            this.splitContainer1.Panel2.Controls.Add(this.btnCount);
            this.splitContainer1.Panel2.Controls.Add(this.btnReverse);
            this.splitContainer1.Panel2.Controls.Add(this.btnLower);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpper);
            this.splitContainer1.Panel2.Controls.Add(this.btnAsciiToHex);
            this.splitContainer1.Panel2.Controls.Add(this.btnHexToAscii);
            this.splitContainer1.Panel2.Controls.Add(this.btnFloatToHex);
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbSplit);
            this.splitContainer1.Panel2.Controls.Add(this.cbTopMost);
            this.splitContainer1.Panel2.Controls.Add(this.btnHexToFloat);
            this.splitContainer1.Panel2.Controls.Add(this.cbHB);
            this.splitContainer1.Size = new System.Drawing.Size(641, 480);
            this.splitContainer1.SplitterDistance = 435;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnClearInput);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.rtbInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.rtbOutput);
            this.splitContainer2.Size = new System.Drawing.Size(435, 480);
            this.splitContainer2.SplitterDistance = 234;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(130, 9);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(86, 23);
            this.btnClearInput.TabIndex = 2;
            this.btnClearInput.Text = "清空输入框";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.BtnClearInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入：";
            // 
            // rtbInput
            // 
            this.rtbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInput.Location = new System.Drawing.Point(3, 35);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(429, 196);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "输出：";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(3, 45);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(429, 194);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(115, 58);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(75, 23);
            this.btnMD5.TabIndex = 13;
            this.btnMD5.Text = "MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.BtnMD5_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(115, 174);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 12;
            this.btnCount.Text = "字符个数";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(115, 145);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 11;
            this.btnReverse.Text = "字符反转";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.BtnReverse_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(115, 116);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(75, 23);
            this.btnLower.TabIndex = 10;
            this.btnLower.Text = "转为小写";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.BtnLower_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(115, 87);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(75, 23);
            this.btnUpper.TabIndex = 9;
            this.btnUpper.Text = "转为大写";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.BtnUpper_Click);
            // 
            // btnAsciiToHex
            // 
            this.btnAsciiToHex.Location = new System.Drawing.Point(16, 116);
            this.btnAsciiToHex.Name = "btnAsciiToHex";
            this.btnAsciiToHex.Size = new System.Drawing.Size(87, 23);
            this.btnAsciiToHex.TabIndex = 8;
            this.btnAsciiToHex.Text = "Ascii->Hex";
            this.btnAsciiToHex.UseVisualStyleBackColor = true;
            this.btnAsciiToHex.Click += new System.EventHandler(this.BtnAsciiToHex_Click);
            // 
            // btnHexToAscii
            // 
            this.btnHexToAscii.Location = new System.Drawing.Point(16, 87);
            this.btnHexToAscii.Name = "btnHexToAscii";
            this.btnHexToAscii.Size = new System.Drawing.Size(87, 23);
            this.btnHexToAscii.TabIndex = 8;
            this.btnHexToAscii.Text = "Hex->Ascii";
            this.btnHexToAscii.UseVisualStyleBackColor = true;
            this.btnHexToAscii.Click += new System.EventHandler(this.BtnHexToAscii_Click);
            // 
            // btnFloatToHex
            // 
            this.btnFloatToHex.Location = new System.Drawing.Point(16, 174);
            this.btnFloatToHex.Name = "btnFloatToHex";
            this.btnFloatToHex.Size = new System.Drawing.Size(87, 23);
            this.btnFloatToHex.TabIndex = 7;
            this.btnFloatToHex.Text = "Float->Hex";
            this.btnFloatToHex.UseVisualStyleBackColor = true;
            this.btnFloatToHex.Click += new System.EventHandler(this.BtnFloatToHex_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(115, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(91, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入格式";
            this.groupBox1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Hex";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ascii";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "分隔:";
            // 
            // tbSplit
            // 
            this.tbSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSplit.Location = new System.Drawing.Point(61, 447);
            this.tbSplit.Name = "tbSplit";
            this.tbSplit.Size = new System.Drawing.Size(114, 23);
            this.tbSplit.TabIndex = 3;
            // 
            // cbTopMost
            // 
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.Location = new System.Drawing.Point(19, 13);
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.Size = new System.Drawing.Size(75, 21);
            this.cbTopMost.TabIndex = 2;
            this.cbTopMost.Text = "钉住窗口";
            this.cbTopMost.UseVisualStyleBackColor = true;
            this.cbTopMost.CheckedChanged += new System.EventHandler(this.CbTopMost_CheckedChanged);
            // 
            // btnHexToFloat
            // 
            this.btnHexToFloat.Location = new System.Drawing.Point(16, 145);
            this.btnHexToFloat.Name = "btnHexToFloat";
            this.btnHexToFloat.Size = new System.Drawing.Size(87, 23);
            this.btnHexToFloat.TabIndex = 1;
            this.btnHexToFloat.Text = "Hex->Float";
            this.btnHexToFloat.UseVisualStyleBackColor = true;
            this.btnHexToFloat.Click += new System.EventHandler(this.BtnHexToFloat_Click);
            // 
            // cbHB
            // 
            this.cbHB.AutoSize = true;
            this.cbHB.Location = new System.Drawing.Point(19, 37);
            this.cbHB.Name = "cbHB";
            this.cbHB.Size = new System.Drawing.Size(87, 21);
            this.cbHB.TabIndex = 0;
            this.cbHB.Text = "高字节在前";
            this.cbHB.UseVisualStyleBackColor = true;
            // 
            // HexCalc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 480);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HexCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HexCalc";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbHB;
        private System.Windows.Forms.CheckBox cbTopMost;
        private System.Windows.Forms.Button btnHexToFloat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSplit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFloatToHex;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnHexToAscii;
        private System.Windows.Forms.Button btnAsciiToHex;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMD5;
    }
}

