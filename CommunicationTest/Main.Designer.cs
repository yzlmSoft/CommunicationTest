namespace CommunicationTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnConnect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Used = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CrcType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbAutoConnect = new System.Windows.Forms.CheckBox();
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
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HexCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrcCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显隐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.系统关联ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.splitContainer1.Panel2.Controls.Add(this.btnConnect);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.cbAutoConnect);
            this.splitContainer1.Panel2.Controls.Add(this.cbAutoReply);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbTime);
            this.splitContainer1.Panel2.Controls.Add(this.btnSendList);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 494);
            this.splitContainer1.SplitterDistance = 650;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 494);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.Location = new System.Drawing.Point(15, 441);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 38);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_ClickAsync);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Used,
            this.CName,
            this.SendType,
            this.Cmd,
            this.r,
            this.n,
            this.CrcType,
            this.Operation});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(624, 427);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView1_RowsRemoved);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
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
            this.CName.FillWeight = 30F;
            this.CName.HeaderText = "名称";
            this.CName.MinimumWidth = 6;
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
            this.SendType.MinimumWidth = 6;
            this.SendType.Name = "SendType";
            // 
            // Cmd
            // 
            this.Cmd.FillWeight = 40F;
            this.Cmd.HeaderText = "发送命令";
            this.Cmd.MinimumWidth = 6;
            this.Cmd.Name = "Cmd";
            // 
            // r
            // 
            this.r.FillWeight = 5F;
            this.r.HeaderText = "回车";
            this.r.MinimumWidth = 6;
            this.r.Name = "r";
            // 
            // n
            // 
            this.n.FillWeight = 5F;
            this.n.HeaderText = "换行";
            this.n.MinimumWidth = 6;
            this.n.Name = "n";
            // 
            // CrcType
            // 
            dataGridViewCellStyle2.NullValue = "None";
            this.CrcType.DefaultCellStyle = dataGridViewCellStyle2;
            this.CrcType.FillWeight = 15F;
            this.CrcType.HeaderText = "校验";
            this.CrcType.Items.AddRange(new object[] {
            "None",
            "Modbus",
            "Crc16_C",
            "UpdateCRC",
            "GBcrc16",
            "HBcrc16",
            "GBcrc16_string",
            "HBcrc16_string",
            "H_GBcrc16_string",
            "H_HBcrc16_string"});
            this.CrcType.MinimumWidth = 6;
            this.CrcType.Name = "CrcType";
            this.CrcType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CrcType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Operation
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "发送";
            this.Operation.DefaultCellStyle = dataGridViewCellStyle3;
            this.Operation.FillWeight = 10F;
            this.Operation.HeaderText = "操作";
            this.Operation.MinimumWidth = 6;
            this.Operation.Name = "Operation";
            this.Operation.Text = "";
            // 
            // cbAutoConnect
            // 
            this.cbAutoConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAutoConnect.AutoSize = true;
            this.cbAutoConnect.Location = new System.Drawing.Point(102, 440);
            this.cbAutoConnect.Name = "cbAutoConnect";
            this.cbAutoConnect.Size = new System.Drawing.Size(75, 21);
            this.cbAutoConnect.TabIndex = 15;
            this.cbAutoConnect.Text = "自动连接";
            this.cbAutoConnect.UseVisualStyleBackColor = true;
            this.cbAutoConnect.CheckedChanged += new System.EventHandler(this.CbAutoConnect_CheckedChanged);
            // 
            // cbAutoReply
            // 
            this.cbAutoReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAutoReply.AutoSize = true;
            this.cbAutoReply.Location = new System.Drawing.Point(102, 462);
            this.cbAutoReply.Name = "cbAutoReply";
            this.cbAutoReply.Size = new System.Drawing.Size(75, 21);
            this.cbAutoReply.TabIndex = 12;
            this.cbAutoReply.Text = "自动回复";
            this.cbAutoReply.UseVisualStyleBackColor = true;
            this.cbAutoReply.CheckedChanged += new System.EventHandler(this.CbAutoReply_CheckedChangedAsync);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "间隔:";
            // 
            // tbTime
            // 
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTime.Location = new System.Drawing.Point(518, 438);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(68, 23);
            this.tbTime.TabIndex = 6;
            this.tbTime.Text = "1000";
            // 
            // btnSendList
            // 
            this.btnSendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendList.Location = new System.Drawing.Point(480, 465);
            this.btnSendList.Name = "btnSendList";
            this.btnSendList.Size = new System.Drawing.Size(130, 23);
            this.btnSendList.TabIndex = 5;
            this.btnSendList.Text = "循环发送列表勾选";
            this.btnSendList.UseVisualStyleBackColor = true;
            this.btnSendList.Click += new System.EventHandler(this.BtnSendList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通讯配置ToolStripMenuItem,
            this.分包规则ToolStripMenuItem,
            this.自动回复ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.显隐ToolStripMenuItem,
            this.配置管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 25);
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
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HexCalcToolStripMenuItem,
            this.CrcCalcToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // HexCalcToolStripMenuItem
            // 
            this.HexCalcToolStripMenuItem.Name = "HexCalcToolStripMenuItem";
            this.HexCalcToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.HexCalcToolStripMenuItem.Text = "HexCalc";
            this.HexCalcToolStripMenuItem.Click += new System.EventHandler(this.HexCalcToolStripMenuItem_Click);
            // 
            // CrcCalcToolStripMenuItem
            // 
            this.CrcCalcToolStripMenuItem.Name = "CrcCalcToolStripMenuItem";
            this.CrcCalcToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.CrcCalcToolStripMenuItem.Text = "CrcCalc";
            this.CrcCalcToolStripMenuItem.Click += new System.EventHandler(this.CrcCalcToolStripMenuItem_Click);
            // 
            // 显隐ToolStripMenuItem
            // 
            this.显隐ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.显隐ToolStripMenuItem.Name = "显隐ToolStripMenuItem";
            this.显隐ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.显隐ToolStripMenuItem.Text = "隐藏";
            this.显隐ToolStripMenuItem.Click += new System.EventHandler(this.显隐toolStripMenuItem_Click);
            // 
            // 配置管理ToolStripMenuItem
            // 
            this.配置管理ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.配置管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出配置ToolStripMenuItem,
            this.导入配置ToolStripMenuItem,
            this.toolStripSeparator1,
            this.系统关联ToolStripMenuItem});
            this.配置管理ToolStripMenuItem.Name = "配置管理ToolStripMenuItem";
            this.配置管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.配置管理ToolStripMenuItem.Text = "配置管理";
            // 
            // 导出配置ToolStripMenuItem
            // 
            this.导出配置ToolStripMenuItem.Name = "导出配置ToolStripMenuItem";
            this.导出配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出配置ToolStripMenuItem.Text = "导出配置";
            this.导出配置ToolStripMenuItem.Click += new System.EventHandler(this.导出配置ToolStripMenuItem_Click);
            // 
            // 导入配置ToolStripMenuItem
            // 
            this.导入配置ToolStripMenuItem.Name = "导入配置ToolStripMenuItem";
            this.导入配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导入配置ToolStripMenuItem.Text = "导入配置";
            this.导入配置ToolStripMenuItem.Click += new System.EventHandler(this.导入配置ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 系统关联ToolStripMenuItem
            // 
            this.系统关联ToolStripMenuItem.Name = "系统关联ToolStripMenuItem";
            this.系统关联ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.系统关联ToolStripMenuItem.Text = "系统关联";
            this.系统关联ToolStripMenuItem.Click += new System.EventHandler(this.系统关联toolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.ClientSize = new System.Drawing.Size(1284, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.ToolStripMenuItem 显隐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HexCalcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CrcCalcToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Used;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewComboBoxColumn SendType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn r;
        private System.Windows.Forms.DataGridViewCheckBoxColumn n;
        private System.Windows.Forms.DataGridViewComboBoxColumn CrcType;
        private System.Windows.Forms.DataGridViewButtonColumn Operation;
        private System.Windows.Forms.ToolStripMenuItem 配置管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 系统关联ToolStripMenuItem;
    }
}

