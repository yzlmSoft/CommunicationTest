﻿namespace CommunicationTest
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Used = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbAutoReply = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btnSendList = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.通讯配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分包规则ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动回复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HexCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显隐toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.cbAutoConnect);
            this.splitContainer1.Panel2.Controls.Add(this.btnConnect);
            this.splitContainer1.Panel2.Controls.Add(this.cbAutoReply);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbTime);
            this.splitContainer1.Panel2.Controls.Add(this.btnSendList);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 494);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 494);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Used,
            this.CName,
            this.SendType,
            this.Cmd,
            this.r,
            this.n,
            this.Operation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(474, 427);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Used
            // 
            this.Used.FillWeight = 5F;
            this.Used.HeaderText = "";
            this.Used.MinimumWidth = 20;
            this.Used.Name = "Used";
            // 
            // CName
            // 
            this.CName.FillWeight = 15F;
            this.CName.HeaderText = "名称";
            this.CName.Name = "CName";
            // 
            // SendType
            // 
            dataGridViewCellStyle1.NullValue = "Hex";
            this.SendType.DefaultCellStyle = dataGridViewCellStyle1;
            this.SendType.FillWeight = 10F;
            this.SendType.HeaderText = "类型";
            this.SendType.Items.AddRange(new object[] {
            "Hex",
            "ASCII",
            "UTF8",
            "GB2312"});
            this.SendType.Name = "SendType";
            // 
            // Cmd
            // 
            this.Cmd.FillWeight = 50F;
            this.Cmd.HeaderText = "发送命令";
            this.Cmd.Name = "Cmd";
            // 
            // r
            // 
            this.r.FillWeight = 5F;
            this.r.HeaderText = "回车";
            this.r.Name = "r";
            // 
            // n
            // 
            this.n.FillWeight = 5F;
            this.n.HeaderText = "换行";
            this.n.Name = "n";
            // 
            // Operation
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "发送";
            this.Operation.DefaultCellStyle = dataGridViewCellStyle2;
            this.Operation.FillWeight = 10F;
            this.Operation.HeaderText = "操作";
            this.Operation.Name = "Operation";
            this.Operation.Text = "";
            // 
            // cbAutoConnect
            // 
            this.cbAutoConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAutoConnect.AutoSize = true;
            this.cbAutoConnect.Location = new System.Drawing.Point(3, 441);
            this.cbAutoConnect.Name = "cbAutoConnect";
            this.cbAutoConnect.Size = new System.Drawing.Size(75, 21);
            this.cbAutoConnect.TabIndex = 15;
            this.cbAutoConnect.Text = "自动连接";
            this.cbAutoConnect.UseVisualStyleBackColor = true;
            this.cbAutoConnect.CheckedChanged += new System.EventHandler(this.cbAutoConnect_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.Location = new System.Drawing.Point(81, 441);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 38);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_ClickAsync);
            // 
            // cbAutoReply
            // 
            this.cbAutoReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAutoReply.AutoSize = true;
            this.cbAutoReply.Location = new System.Drawing.Point(3, 463);
            this.cbAutoReply.Name = "cbAutoReply";
            this.cbAutoReply.Size = new System.Drawing.Size(75, 21);
            this.cbAutoReply.TabIndex = 12;
            this.cbAutoReply.Text = "自动回复";
            this.cbAutoReply.UseVisualStyleBackColor = true;
            this.cbAutoReply.CheckedChanged += new System.EventHandler(this.cbAutoReply_CheckedChangedAsync);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "间隔:";
            // 
            // tbTime
            // 
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTime.Location = new System.Drawing.Point(368, 438);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(68, 23);
            this.tbTime.TabIndex = 6;
            this.tbTime.Text = "1000";
            // 
            // btnSendList
            // 
            this.btnSendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendList.Location = new System.Drawing.Point(330, 465);
            this.btnSendList.Name = "btnSendList";
            this.btnSendList.Size = new System.Drawing.Size(130, 23);
            this.btnSendList.TabIndex = 5;
            this.btnSendList.Text = "循环发送列表勾选";
            this.btnSendList.UseVisualStyleBackColor = true;
            this.btnSendList.Click += new System.EventHandler(this.btnSendList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通讯配置ToolStripMenuItem,
            this.分包规则ToolStripMenuItem,
            this.自动回复ToolStripMenuItem,
            this.导出配置ToolStripMenuItem,
            this.导入配置ToolStripMenuItem,
            this.工具toolStripMenuItem,
            this.显隐toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 通讯配置ToolStripMenuItem
            // 
            this.通讯配置ToolStripMenuItem.Name = "通讯配置ToolStripMenuItem";
            this.通讯配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.通讯配置ToolStripMenuItem.Text = "通讯配置";
            this.通讯配置ToolStripMenuItem.Click += new System.EventHandler(this.通讯配置ToolStripMenuItem_Click);
            // 
            // 分包规则ToolStripMenuItem
            // 
            this.分包规则ToolStripMenuItem.Name = "分包规则ToolStripMenuItem";
            this.分包规则ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.分包规则ToolStripMenuItem.Text = "分包规则";
            this.分包规则ToolStripMenuItem.Click += new System.EventHandler(this.分包规则ToolStripMenuItem_Click);
            // 
            // 自动回复ToolStripMenuItem
            // 
            this.自动回复ToolStripMenuItem.Name = "自动回复ToolStripMenuItem";
            this.自动回复ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.自动回复ToolStripMenuItem.Text = "自动回复";
            this.自动回复ToolStripMenuItem.Click += new System.EventHandler(this.自动回复ToolStripMenuItem_Click);
            // 
            // 导出配置ToolStripMenuItem
            // 
            this.导出配置ToolStripMenuItem.Name = "导出配置ToolStripMenuItem";
            this.导出配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导出配置ToolStripMenuItem.Text = "导出配置";
            this.导出配置ToolStripMenuItem.Click += new System.EventHandler(this.导出配置ToolStripMenuItem_Click);
            // 
            // 导入配置ToolStripMenuItem
            // 
            this.导入配置ToolStripMenuItem.Name = "导入配置ToolStripMenuItem";
            this.导入配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导入配置ToolStripMenuItem.Text = "导入配置";
            this.导入配置ToolStripMenuItem.Click += new System.EventHandler(this.导入配置ToolStripMenuItem_Click);
            // 
            // 工具toolStripMenuItem
            // 
            this.工具toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HexCalcToolStripMenuItem});
            this.工具toolStripMenuItem.Name = "工具toolStripMenuItem";
            this.工具toolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具toolStripMenuItem.Text = "工具";
            // 
            // HexCalcToolStripMenuItem
            // 
            this.HexCalcToolStripMenuItem.Name = "HexCalcToolStripMenuItem";
            this.HexCalcToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.HexCalcToolStripMenuItem.Text = "HexCalc";
            this.HexCalcToolStripMenuItem.Click += new System.EventHandler(this.HexCalcToolStripMenuItem_Click);
            // 
            // 显隐toolStripMenuItem
            // 
            this.显隐toolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.显隐toolStripMenuItem.Name = "显隐toolStripMenuItem";
            this.显隐toolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.显隐toolStripMenuItem.Text = "隐藏";
            this.显隐toolStripMenuItem.Click += new System.EventHandler(this.显隐toolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简单通讯测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_LoadAsync);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btnSendList;
        private System.Windows.Forms.CheckBox cbAutoReply;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 通讯配置ToolStripMenuItem;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ToolStripMenuItem 分包规则ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动回复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox cbAutoConnect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Used;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewComboBoxColumn SendType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn r;
        private System.Windows.Forms.DataGridViewCheckBoxColumn n;
        private System.Windows.Forms.DataGridViewButtonColumn Operation;
        private System.Windows.Forms.ToolStripMenuItem 导出配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显隐toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HexCalcToolStripMenuItem;
    }
}

