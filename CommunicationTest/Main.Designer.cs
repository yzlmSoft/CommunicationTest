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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            btnConnect = new Button();
            dataGridView1 = new DataGridView();
            cbAutoConnect = new CheckBox();
            cbAutoReply = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            tbTime = new TextBox();
            btnSendList = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            通讯配置ToolStripMenuItem = new ToolStripMenuItem();
            分包规则ToolStripMenuItem = new ToolStripMenuItem();
            自动回复ToolStripMenuItem = new ToolStripMenuItem();
            工具ToolStripMenuItem = new ToolStripMenuItem();
            HexCalcToolStripMenuItem = new ToolStripMenuItem();
            CrcCalcToolStripMenuItem = new ToolStripMenuItem();
            显隐ToolStripMenuItem = new ToolStripMenuItem();
            配置管理ToolStripMenuItem = new ToolStripMenuItem();
            导出配置ToolStripMenuItem = new ToolStripMenuItem();
            导入配置ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            系统关联ToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            关闭ToolStripMenuItem = new ToolStripMenuItem();
            Used = new DataGridViewCheckBoxColumn();
            CName = new DataGridViewTextBoxColumn();
            SendType = new DataGridViewComboBoxColumn();
            Cmd = new DataGridViewTextBoxColumn();
            r = new DataGridViewCheckBoxColumn();
            n = new DataGridViewCheckBoxColumn();
            CrcType = new DataGridViewComboBoxColumn();
            Operation = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnConnect);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(cbAutoConnect);
            splitContainer1.Panel2.Controls.Add(cbAutoReply);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(tbTime);
            splitContainer1.Panel2.Controls.Add(btnSendList);
            splitContainer1.Size = new Size(1284, 494);
            splitContainer1.SplitterDistance = 650;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(650, 494);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConnect.Location = new Point(15, 441);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(81, 38);
            btnConnect.TabIndex = 14;
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += BtnConnect_ClickAsync;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Used, CName, SendType, Cmd, r, n, CrcType, Operation });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("宋体", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(624, 427);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridView1.CellEnter += DataGridView1_CellEnter;
            dataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += DataGridView1_DataError;
            dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            // 
            // cbAutoConnect
            // 
            cbAutoConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbAutoConnect.AutoSize = true;
            cbAutoConnect.Location = new Point(102, 440);
            cbAutoConnect.Name = "cbAutoConnect";
            cbAutoConnect.Size = new Size(75, 21);
            cbAutoConnect.TabIndex = 15;
            cbAutoConnect.Text = "自动连接";
            cbAutoConnect.UseVisualStyleBackColor = true;
            cbAutoConnect.CheckedChanged += CbAutoConnect_CheckedChanged;
            // 
            // cbAutoReply
            // 
            cbAutoReply.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbAutoReply.AutoSize = true;
            cbAutoReply.Location = new Point(102, 462);
            cbAutoReply.Name = "cbAutoReply";
            cbAutoReply.Size = new Size(75, 21);
            cbAutoReply.TabIndex = 12;
            cbAutoReply.Text = "自动回复";
            cbAutoReply.UseVisualStyleBackColor = true;
            cbAutoReply.CheckedChanged += CbAutoReply_CheckedChangedAsync;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(592, 441);
            label4.Name = "label4";
            label4.Size = new Size(25, 17);
            label4.TabIndex = 8;
            label4.Text = "ms";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(477, 441);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 7;
            label3.Text = "间隔:";
            // 
            // tbTime
            // 
            tbTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbTime.Location = new Point(518, 438);
            tbTime.Name = "tbTime";
            tbTime.Size = new Size(68, 23);
            tbTime.TabIndex = 6;
            tbTime.Text = "1000";
            // 
            // btnSendList
            // 
            btnSendList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSendList.Location = new Point(480, 465);
            btnSendList.Name = "btnSendList";
            btnSendList.Size = new Size(130, 23);
            btnSendList.TabIndex = 5;
            btnSendList.Text = "循环发送列表勾选";
            btnSendList.UseVisualStyleBackColor = true;
            btnSendList.Click += BtnSendList_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 519);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1284, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 通讯配置ToolStripMenuItem, 分包规则ToolStripMenuItem, 自动回复ToolStripMenuItem, 工具ToolStripMenuItem, 显隐ToolStripMenuItem, 配置管理ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1284, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 通讯配置ToolStripMenuItem
            // 
            通讯配置ToolStripMenuItem.Name = "通讯配置ToolStripMenuItem";
            通讯配置ToolStripMenuItem.Size = new Size(68, 21);
            通讯配置ToolStripMenuItem.Text = "通讯配置";
            通讯配置ToolStripMenuItem.Click += 通讯配置ToolStripMenuItem_Click;
            // 
            // 分包规则ToolStripMenuItem
            // 
            分包规则ToolStripMenuItem.Name = "分包规则ToolStripMenuItem";
            分包规则ToolStripMenuItem.Size = new Size(68, 21);
            分包规则ToolStripMenuItem.Text = "分包规则";
            分包规则ToolStripMenuItem.Click += 分包规则ToolStripMenuItem_Click;
            // 
            // 自动回复ToolStripMenuItem
            // 
            自动回复ToolStripMenuItem.Name = "自动回复ToolStripMenuItem";
            自动回复ToolStripMenuItem.Size = new Size(68, 21);
            自动回复ToolStripMenuItem.Text = "自动回复";
            自动回复ToolStripMenuItem.Click += 自动回复ToolStripMenuItem_Click;
            // 
            // 工具ToolStripMenuItem
            // 
            工具ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { HexCalcToolStripMenuItem, CrcCalcToolStripMenuItem });
            工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            工具ToolStripMenuItem.Size = new Size(44, 21);
            工具ToolStripMenuItem.Text = "工具";
            // 
            // HexCalcToolStripMenuItem
            // 
            HexCalcToolStripMenuItem.Name = "HexCalcToolStripMenuItem";
            HexCalcToolStripMenuItem.Size = new Size(122, 22);
            HexCalcToolStripMenuItem.Text = "HexCalc";
            HexCalcToolStripMenuItem.Click += HexCalcToolStripMenuItem_Click;
            // 
            // CrcCalcToolStripMenuItem
            // 
            CrcCalcToolStripMenuItem.Name = "CrcCalcToolStripMenuItem";
            CrcCalcToolStripMenuItem.Size = new Size(122, 22);
            CrcCalcToolStripMenuItem.Text = "CrcCalc";
            CrcCalcToolStripMenuItem.Click += CrcCalcToolStripMenuItem_Click;
            // 
            // 显隐ToolStripMenuItem
            // 
            显隐ToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            显隐ToolStripMenuItem.Name = "显隐ToolStripMenuItem";
            显隐ToolStripMenuItem.Size = new Size(44, 21);
            显隐ToolStripMenuItem.Text = "隐藏";
            显隐ToolStripMenuItem.Click += 显隐toolStripMenuItem_Click;
            // 
            // 配置管理ToolStripMenuItem
            // 
            配置管理ToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            配置管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 导出配置ToolStripMenuItem, 导入配置ToolStripMenuItem, toolStripSeparator1, 系统关联ToolStripMenuItem });
            配置管理ToolStripMenuItem.Name = "配置管理ToolStripMenuItem";
            配置管理ToolStripMenuItem.Size = new Size(68, 21);
            配置管理ToolStripMenuItem.Text = "配置管理";
            // 
            // 导出配置ToolStripMenuItem
            // 
            导出配置ToolStripMenuItem.Name = "导出配置ToolStripMenuItem";
            导出配置ToolStripMenuItem.Size = new Size(124, 22);
            导出配置ToolStripMenuItem.Text = "导出配置";
            导出配置ToolStripMenuItem.Click += 导出配置ToolStripMenuItem_Click;
            // 
            // 导入配置ToolStripMenuItem
            // 
            导入配置ToolStripMenuItem.Name = "导入配置ToolStripMenuItem";
            导入配置ToolStripMenuItem.Size = new Size(124, 22);
            导入配置ToolStripMenuItem.Text = "导入配置";
            导入配置ToolStripMenuItem.Click += 导入配置ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(121, 6);
            // 
            // 系统关联ToolStripMenuItem
            // 
            系统关联ToolStripMenuItem.Name = "系统关联ToolStripMenuItem";
            系统关联ToolStripMenuItem.Size = new Size(124, 22);
            系统关联ToolStripMenuItem.Text = "系统关联";
            系统关联ToolStripMenuItem.Click += 系统关联toolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 关闭ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 26);
            // 
            // 关闭ToolStripMenuItem
            // 
            关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            关闭ToolStripMenuItem.Size = new Size(100, 22);
            关闭ToolStripMenuItem.Text = "关闭";
            关闭ToolStripMenuItem.Click += 关闭ToolStripMenuItem_Click;
            // 
            // Used
            // 
            Used.FillWeight = 5F;
            Used.HeaderText = "";
            Used.MinimumWidth = 20;
            Used.Name = "Used";
            // 
            // CName
            // 
            CName.FillWeight = 30F;
            CName.HeaderText = "名称";
            CName.MinimumWidth = 6;
            CName.Name = "CName";
            // 
            // SendType
            // 
            dataGridViewCellStyle1.NullValue = "Hex";
            SendType.DefaultCellStyle = dataGridViewCellStyle1;
            SendType.FillWeight = 10F;
            SendType.HeaderText = "类型";
            SendType.Items.AddRange(new object[] { "Hex", "ASCII", "UTF8", "GB2312" });
            SendType.MinimumWidth = 6;
            SendType.Name = "SendType";
            // 
            // Cmd
            // 
            Cmd.FillWeight = 40F;
            Cmd.HeaderText = "发送命令";
            Cmd.MinimumWidth = 6;
            Cmd.Name = "Cmd";
            // 
            // r
            // 
            r.FillWeight = 5F;
            r.HeaderText = "回车";
            r.MinimumWidth = 6;
            r.Name = "r";
            // 
            // n
            // 
            n.FillWeight = 5F;
            n.HeaderText = "换行";
            n.MinimumWidth = 6;
            n.Name = "n";
            // 
            // CrcType
            // 
            dataGridViewCellStyle2.NullValue = "None";
            CrcType.DefaultCellStyle = dataGridViewCellStyle2;
            CrcType.FillWeight = 15F;
            CrcType.HeaderText = "校验";
            CrcType.Items.AddRange(new object[] { "None", "Modbus", "Crc16_R", "UpdateCRC", "GBcrc16", "HBcrc16", "GBcrc16_string", "HBcrc16_string", "H_GBcrc16_string", "H_HBcrc16_string" });
            CrcType.MinimumWidth = 6;
            CrcType.Name = "CrcType";
            CrcType.Resizable = DataGridViewTriState.True;
            CrcType.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Operation
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "发送";
            Operation.DefaultCellStyle = dataGridViewCellStyle3;
            Operation.FillWeight = 10F;
            Operation.HeaderText = "操作";
            Operation.MinimumWidth = 6;
            Operation.Name = "Operation";
            Operation.Text = "";
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1284, 541);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "简单通讯测试";
            FormClosing += Main_FormClosing;
            Load += Main_LoadAsync;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem 配置管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 系统关联ToolStripMenuItem;
        private DataGridViewCheckBoxColumn Used;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewComboBoxColumn SendType;
        private DataGridViewTextBoxColumn Cmd;
        private DataGridViewCheckBoxColumn r;
        private DataGridViewCheckBoxColumn n;
        private DataGridViewComboBoxColumn CrcType;
        private DataGridViewButtonColumn Operation;
    }
}

