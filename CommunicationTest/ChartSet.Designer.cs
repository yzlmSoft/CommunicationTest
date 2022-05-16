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
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "类型";
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Location = new System.Drawing.Point(81, 50);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(121, 25);
            this.cmbDataType.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "点数";
            // 
            // tbPointCount
            // 
            this.tbPointCount.Location = new System.Drawing.Point(81, 12);
            this.tbPointCount.Name = "tbPointCount";
            this.tbPointCount.Size = new System.Drawing.Size(121, 23);
            this.tbPointCount.TabIndex = 13;
            this.tbPointCount.Text = "100000";
            // 
            // cbLow
            // 
            this.cbLow.AutoSize = true;
            this.cbLow.Checked = true;
            this.cbLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLow.Location = new System.Drawing.Point(231, 52);
            this.cbLow.Name = "cbLow";
            this.cbLow.Size = new System.Drawing.Size(87, 21);
            this.cbLow.TabIndex = 17;
            this.cbLow.Text = "低字节在前";
            this.cbLow.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(324, 50);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(318, 12);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(121, 23);
            this.tbIndex.TabIndex = 13;
            this.tbIndex.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "起始字节索引";
            // 
            // ChartSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 85);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbLow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDataType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.tbPointCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChartSet";
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
    }
}