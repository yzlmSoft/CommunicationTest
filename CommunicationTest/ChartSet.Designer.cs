namespace CommunicationTest
{
    partial class ChartSet
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPointCount = new System.Windows.Forms.TextBox();
            this.cbLow = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFormula = new System.Windows.Forms.TextBox();
            this.cbASCII = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLenth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "类型";
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Location = new System.Drawing.Point(336, 36);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(121, 25);
            this.cmbDataType.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "点数";
            // 
            // tbPointCount
            // 
            this.tbPointCount.Location = new System.Drawing.Point(50, 6);
            this.tbPointCount.Name = "tbPointCount";
            this.tbPointCount.Size = new System.Drawing.Size(145, 23);
            this.tbPointCount.TabIndex = 13;
            this.tbPointCount.Text = "100000";
            // 
            // cbLow
            // 
            this.cbLow.AutoSize = true;
            this.cbLow.Checked = true;
            this.cbLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLow.Location = new System.Drawing.Point(203, 38);
            this.cbLow.Name = "cbLow";
            this.cbLow.Size = new System.Drawing.Size(87, 21);
            this.cbLow.TabIndex = 17;
            this.cbLow.Text = "低字节在前";
            this.cbLow.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(463, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 84);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(98, 36);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(97, 23);
            this.tbIndex.TabIndex = 13;
            this.tbIndex.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "起始字节位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "后期处理($value为解析得到的值)";
            // 
            // tbFormula
            // 
            this.tbFormula.Location = new System.Drawing.Point(203, 67);
            this.tbFormula.Name = "tbFormula";
            this.tbFormula.Size = new System.Drawing.Size(254, 23);
            this.tbFormula.TabIndex = 13;
            this.tbFormula.Text = "$value";
            // 
            // cbASCII
            // 
            this.cbASCII.AutoSize = true;
            this.cbASCII.Location = new System.Drawing.Point(203, 8);
            this.cbASCII.Name = "cbASCII";
            this.cbASCII.Size = new System.Drawing.Size(58, 21);
            this.cbASCII.TabIndex = 17;
            this.cbASCII.Text = "ASCII";
            this.cbASCII.UseVisualStyleBackColor = true;
            this.cbASCII.CheckedChanged += new System.EventHandler(this.cbASCII_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "长度";
            this.label4.Visible = false;
            // 
            // tbLenth
            // 
            this.tbLenth.Location = new System.Drawing.Point(336, 6);
            this.tbLenth.Name = "tbLenth";
            this.tbLenth.Size = new System.Drawing.Size(121, 23);
            this.tbLenth.TabIndex = 22;
            this.tbLenth.Visible = false;
            // 
            // ChartSet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(542, 104);
            this.Controls.Add(this.tbLenth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbASCII);
            this.Controls.Add(this.cbLow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDataType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.tbFormula);
            this.Controls.Add(this.tbPointCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChartSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChartSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private ComboBox cmbDataType;
        private Label label3;
        private TextBox tbPointCount;
        private CheckBox cbLow;
        private Button btnOk;
        private TextBox tbIndex;
        private Label label1;
        private Label label2;
        private TextBox tbFormula;
        private CheckBox cbASCII;
        private Label label4;
        private TextBox tbLenth;
    }
}