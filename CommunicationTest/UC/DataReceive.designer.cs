namespace CommunicationTest
{
    partial class DataReceive
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.保存接收数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制接收数据曲线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxAutoLine = new System.Windows.Forms.CheckBox();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.rbtnASCII = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.LinkLabel();
            this.rbtnUTF8 = new System.Windows.Forms.RadioButton();
            this.rbtnGB2312 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbAutoSave = new System.Windows.Forms.CheckBox();
            this.cbSend = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSCount = new System.Windows.Forms.LinkLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtData = new System.Windows.Forms.TextBox();
            this.realtimeChart1 = new ChartTest.Controls.RealtimeChart();
            this.CMS_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMS_Main
            // 
            this.CMS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Clear,
            this.MS_ToInt,
            this.MS_ToFloat,
            this.MS_ToDouble,
            this.保存接收数据ToolStripMenuItem,
            this.绘制接收数据曲线ToolStripMenuItem});
            this.CMS_Main.Name = "contextMenuStrip1";
            this.CMS_Main.ShowImageMargin = false;
            this.CMS_Main.Size = new System.Drawing.Size(174, 136);
            this.CMS_Main.VisibleChanged += new System.EventHandler(this.CMS_Main_VisibleChanged);
            // 
            // MS_Clear
            // 
            this.MS_Clear.Name = "MS_Clear";
            this.MS_Clear.Size = new System.Drawing.Size(173, 22);
            this.MS_Clear.Text = "清空";
            this.MS_Clear.Click += new System.EventHandler(this.MS_Clear_Click);
            // 
            // MS_ToInt
            // 
            this.MS_ToInt.Name = "MS_ToInt";
            this.MS_ToInt.Size = new System.Drawing.Size(173, 22);
            this.MS_ToInt.Text = "转换为整数(Int)";
            this.MS_ToInt.Click += new System.EventHandler(this.MS_ToInt_Click);
            // 
            // MS_ToFloat
            // 
            this.MS_ToFloat.Name = "MS_ToFloat";
            this.MS_ToFloat.Size = new System.Drawing.Size(173, 22);
            this.MS_ToFloat.Text = "转换为浮点数(Float)";
            this.MS_ToFloat.Click += new System.EventHandler(this.MS_ToFloat_Click);
            // 
            // MS_ToDouble
            // 
            this.MS_ToDouble.Name = "MS_ToDouble";
            this.MS_ToDouble.Size = new System.Drawing.Size(173, 22);
            this.MS_ToDouble.Text = "转换为浮点数(Double)";
            this.MS_ToDouble.Click += new System.EventHandler(this.MS_ToDouble_Click);
            // 
            // 保存接收数据ToolStripMenuItem
            // 
            this.保存接收数据ToolStripMenuItem.Name = "保存接收数据ToolStripMenuItem";
            this.保存接收数据ToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.保存接收数据ToolStripMenuItem.Text = "保存接收数据";
            this.保存接收数据ToolStripMenuItem.Click += new System.EventHandler(this.保存接收数据ToolStripMenuItem_Click);
            // 
            // 绘制接收数据曲线ToolStripMenuItem
            // 
            this.绘制接收数据曲线ToolStripMenuItem.Name = "绘制接收数据曲线ToolStripMenuItem";
            this.绘制接收数据曲线ToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.绘制接收数据曲线ToolStripMenuItem.Text = "绘制接收数据曲线";
            this.绘制接收数据曲线ToolStripMenuItem.Click += new System.EventHandler(this.绘制接收数据曲线ToolStripMenuItem_Click);
            // 
            // cbxAutoLine
            // 
            this.cbxAutoLine.AutoSize = true;
            this.cbxAutoLine.Checked = true;
            this.cbxAutoLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoLine.Location = new System.Drawing.Point(0, 3);
            this.cbxAutoLine.Name = "cbxAutoLine";
            this.cbxAutoLine.Size = new System.Drawing.Size(75, 21);
            this.cbxAutoLine.TabIndex = 2;
            this.cbxAutoLine.Text = "自动换行";
            this.cbxAutoLine.UseVisualStyleBackColor = true;
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Checked = true;
            this.rbtnHex.Location = new System.Drawing.Point(69, 3);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(48, 21);
            this.rbtnHex.TabIndex = 3;
            this.rbtnHex.TabStop = true;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            this.rbtnHex.CheckedChanged += new System.EventHandler(this.RbtnHex_CheckedChanged);
            // 
            // rbtnASCII
            // 
            this.rbtnASCII.AutoSize = true;
            this.rbtnASCII.Location = new System.Drawing.Point(116, 3);
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.Size = new System.Drawing.Size(57, 21);
            this.rbtnASCII.TabIndex = 4;
            this.rbtnASCII.Text = "ASCII";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            this.rbtnASCII.CheckedChanged += new System.EventHandler(this.RbtnASCII_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "接收字节数：";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(76, 194);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 17);
            this.lblCount.TabIndex = 6;
            this.lblCount.TabStop = true;
            this.lblCount.Text = "0";
            this.lblCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbCount_LinkClicked);
            // 
            // rbtnUTF8
            // 
            this.rbtnUTF8.AutoSize = true;
            this.rbtnUTF8.Location = new System.Drawing.Point(175, 3);
            this.rbtnUTF8.Name = "rbtnUTF8";
            this.rbtnUTF8.Size = new System.Drawing.Size(55, 21);
            this.rbtnUTF8.TabIndex = 7;
            this.rbtnUTF8.Text = "UTF8";
            this.rbtnUTF8.UseVisualStyleBackColor = true;
            this.rbtnUTF8.CheckedChanged += new System.EventHandler(this.RbtnUTF8_CheckedChanged);
            // 
            // rbtnGB2312
            // 
            this.rbtnGB2312.AutoSize = true;
            this.rbtnGB2312.Location = new System.Drawing.Point(228, 3);
            this.rbtnGB2312.Name = "rbtnGB2312";
            this.rbtnGB2312.Size = new System.Drawing.Size(71, 21);
            this.rbtnGB2312.TabIndex = 8;
            this.rbtnGB2312.Text = "GB2312";
            this.rbtnGB2312.UseVisualStyleBackColor = true;
            this.rbtnGB2312.CheckedChanged += new System.EventHandler(this.RbtnGB2312_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(440, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "提示：右键Hex计算数值";
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Checked = true;
            this.cbTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTime.Location = new System.Drawing.Point(305, 4);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(99, 21);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "显示接收时间";
            this.cbTime.UseVisualStyleBackColor = true;
            // 
            // cbAutoSave
            // 
            this.cbAutoSave.AutoSize = true;
            this.cbAutoSave.Location = new System.Drawing.Point(491, 4);
            this.cbAutoSave.Name = "cbAutoSave";
            this.cbAutoSave.Size = new System.Drawing.Size(75, 21);
            this.cbAutoSave.TabIndex = 2;
            this.cbAutoSave.Text = "自动存储";
            this.cbAutoSave.UseVisualStyleBackColor = true;
            this.cbAutoSave.CheckedChanged += new System.EventHandler(this.CbAutoSave_CheckedChanged);
            // 
            // cbSend
            // 
            this.cbSend.AutoSize = true;
            this.cbSend.Checked = true;
            this.cbSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSend.Location = new System.Drawing.Point(410, 4);
            this.cbSend.Name = "cbSend";
            this.cbSend.Size = new System.Drawing.Size(75, 21);
            this.cbSend.TabIndex = 2;
            this.cbSend.Text = "显示发送";
            this.cbSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "发送字节数：";
            // 
            // lbSCount
            // 
            this.lbSCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSCount.AutoSize = true;
            this.lbSCount.Location = new System.Drawing.Point(279, 194);
            this.lbSCount.Name = "lbSCount";
            this.lbSCount.Size = new System.Drawing.Size(15, 17);
            this.lbSCount.TabIndex = 6;
            this.lbSCount.TabStop = true;
            this.lbSCount.Text = "0";
            this.lbSCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbCount_LinkClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.realtimeChart1);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(569, 160);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 10;
            // 
            // txtData
            // 
            this.txtData.ContextMenuStrip = this.CMS_Main;
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(0, 0);
            this.txtData.MaxLength = 1;
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(569, 160);
            this.txtData.TabIndex = 2;
            // 
            // realtimeChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.AxisPen.Width = 2;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Labels.Axis = this.realtimeChart1.Axes.Bottom;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.realtimeChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.realtimeChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.realtimeChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.MinorTicks.Length = 2;
            this.realtimeChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Ticks.Length = 4;
            this.realtimeChart1.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.TicksInner.Length = 0;
            this.realtimeChart1.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.realtimeChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.realtimeChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Bottom.Title.Font.Size = 11;
            this.realtimeChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.realtimeChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.AxisPen.Visible = false;
            this.realtimeChart1.Axes.Depth.AxisPen.Width = 2;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Labels.Axis = this.realtimeChart1.Axes.Depth;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.realtimeChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Depth.Labels.Font.Size = 9;
            this.realtimeChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.realtimeChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.MinorTicks.Length = 2;
            this.realtimeChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Ticks.Length = 4;
            this.realtimeChart1.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.TicksInner.Length = 0;
            this.realtimeChart1.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.realtimeChart1.Axes.Depth.Title.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.realtimeChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Depth.Title.Font.Size = 11;
            this.realtimeChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.realtimeChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.AxisPen.Visible = false;
            this.realtimeChart1.Axes.DepthTop.AxisPen.Width = 2;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Labels.Axis = this.realtimeChart1.Axes.DepthTop;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.realtimeChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.realtimeChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.MinorTicks.Length = 2;
            this.realtimeChart1.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Ticks.Length = 4;
            this.realtimeChart1.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.TicksInner.Length = 0;
            this.realtimeChart1.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.realtimeChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.realtimeChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.realtimeChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.realtimeChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.AxisPen.Visible = false;
            this.realtimeChart1.Axes.Left.AxisPen.Width = 2;
            this.realtimeChart1.Axes.Left.FixedLabelSize = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Labels.Axis = this.realtimeChart1.Axes.Left;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Axes.Left.Labels.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.realtimeChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Left.Labels.Font.Size = 9;
            this.realtimeChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.realtimeChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.MinorTicks.Length = 2;
            this.realtimeChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Ticks.Length = 4;
            this.realtimeChart1.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.TicksInner.Length = 0;
            this.realtimeChart1.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.realtimeChart1.Axes.Left.Title.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.realtimeChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Left.Title.Font.Size = 11;
            this.realtimeChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            this.realtimeChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.AxisPen.Visible = false;
            this.realtimeChart1.Axes.Right.AxisPen.Width = 2;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Labels.Axis = this.realtimeChart1.Axes.Right;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Axes.Right.Labels.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.realtimeChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Right.Labels.Font.Size = 9;
            this.realtimeChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.realtimeChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.MinorTicks.Length = 2;
            this.realtimeChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Ticks.Length = 4;
            this.realtimeChart1.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.TicksInner.Length = 0;
            this.realtimeChart1.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.realtimeChart1.Axes.Right.Title.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.realtimeChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Right.Title.Font.Size = 11;
            this.realtimeChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            this.realtimeChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.AxisPen.Width = 2;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Labels.Axis = this.realtimeChart1.Axes.Top;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Axes.Top.Labels.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.realtimeChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Top.Labels.Font.Size = 9;
            this.realtimeChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.realtimeChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.MinorTicks.Length = 2;
            this.realtimeChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Ticks.Length = 4;
            this.realtimeChart1.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.TicksInner.Length = 0;
            this.realtimeChart1.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.realtimeChart1.Axes.Top.Title.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.realtimeChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Axes.Top.Title.Font.Size = 11;
            this.realtimeChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            this.realtimeChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.realtimeChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.realtimeChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.realtimeChart1.Footer.Brush.Solid = true;
            this.realtimeChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.realtimeChart1.Footer.Font.Brush.Solid = true;
            this.realtimeChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Footer.Font.Size = 8;
            this.realtimeChart1.Footer.Font.SizeFloat = 8F;
            this.realtimeChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Footer.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Footer.Shadow.Brush.Solid = true;
            this.realtimeChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.realtimeChart1.Header.Brush.Solid = true;
            this.realtimeChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.realtimeChart1.Header.Font.Brush.Solid = true;
            this.realtimeChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Header.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Header.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Header.Font.Size = 12;
            this.realtimeChart1.Header.Font.SizeFloat = 12F;
            this.realtimeChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Header.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Header.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.realtimeChart1.Header.Shadow.Brush.Solid = true;
            this.realtimeChart1.Header.Shadow.Brush.Visible = true;
            this.realtimeChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Legend.Brush.Solid = true;
            this.realtimeChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.realtimeChart1.Legend.Font.Brush.Solid = true;
            this.realtimeChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Legend.Font.Size = 9;
            this.realtimeChart1.Legend.Font.SizeFloat = 9F;
            this.realtimeChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Legend.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.realtimeChart1.Legend.Shadow.Brush.Solid = true;
            this.realtimeChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Legend.Symbol.Legend = this.realtimeChart1.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.realtimeChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Legend.Title.Brush.Solid = true;
            this.realtimeChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.realtimeChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.realtimeChart1.Legend.Title.Font.Brush.Solid = true;
            this.realtimeChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.Legend.Title.Font.Size = 8;
            this.realtimeChart1.Legend.Title.Font.SizeFloat = 8F;
            this.realtimeChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.realtimeChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.realtimeChart1.Legend.Visible = false;
            this.realtimeChart1.Location = new System.Drawing.Point(0, 0);
            this.realtimeChart1.Name = "realtimeChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.realtimeChart1.Panel.Brush.Gradient.UseMiddle = true;
            this.realtimeChart1.Panel.Brush.Solid = true;
            this.realtimeChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Panel.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Panel.Shadow.Brush.Solid = true;
            this.realtimeChart1.Panel.Shadow.Brush.Visible = true;
            this.realtimeChart1.Size = new System.Drawing.Size(569, 76);
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.realtimeChart1.SubFooter.Brush.Solid = true;
            this.realtimeChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.realtimeChart1.SubFooter.Font.Brush.Solid = true;
            this.realtimeChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.SubFooter.Font.Size = 8;
            this.realtimeChart1.SubFooter.Font.SizeFloat = 8F;
            this.realtimeChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.SubFooter.Shadow.Brush.Solid = true;
            this.realtimeChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.realtimeChart1.SubHeader.Brush.Solid = true;
            this.realtimeChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.realtimeChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.realtimeChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.realtimeChart1.SubHeader.Font.Brush.Solid = true;
            this.realtimeChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.realtimeChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.realtimeChart1.SubHeader.Font.Size = 12;
            this.realtimeChart1.SubHeader.Font.SizeFloat = 12F;
            this.realtimeChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.realtimeChart1.SubHeader.Shadow.Brush.Solid = true;
            this.realtimeChart1.SubHeader.Shadow.Brush.Visible = true;
            this.realtimeChart1.TabIndex = 0;
            this.realtimeChart1.Text = "realtimeChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.realtimeChart1.Walls.Back.Brush.Gradient.Visible = true;
            this.realtimeChart1.Walls.Back.Brush.Solid = true;
            this.realtimeChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.realtimeChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.realtimeChart1.Walls.Bottom.Brush.Solid = true;
            this.realtimeChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.realtimeChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.realtimeChart1.Walls.Left.Brush.Solid = true;
            this.realtimeChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.realtimeChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.realtimeChart1.Walls.Right.Brush.Solid = true;
            this.realtimeChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.realtimeChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.realtimeChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.realtimeChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.realtimeChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.realtimeChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.realtimeChart1.Zoom.Brush.Solid = true;
            this.realtimeChart1.Zoom.Brush.Visible = true;
            this.realtimeChart1.Zoom.FullRepaint = true;
            this.realtimeChart1.DoubleClick += new System.EventHandler(this.realtimeChart1_DoubleClick);
            // 
            // DataReceive
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnGB2312);
            this.Controls.Add(this.rbtnUTF8);
            this.Controls.Add(this.lbSCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnASCII);
            this.Controls.Add(this.rbtnHex);
            this.Controls.Add(this.cbAutoSave);
            this.Controls.Add(this.cbSend);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbxAutoLine);
            this.Name = "DataReceive";
            this.Size = new System.Drawing.Size(575, 210);
            this.CMS_Main.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbxAutoLine;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.RadioButton rbtnASCII;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_ToInt;
        private System.Windows.Forms.ToolStripMenuItem MS_ToFloat;
        private System.Windows.Forms.ToolStripMenuItem MS_ToDouble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblCount;
        private System.Windows.Forms.RadioButton rbtnUTF8;
        private System.Windows.Forms.RadioButton rbtnGB2312;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.ToolStripMenuItem 保存接收数据ToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbAutoSave;
        private System.Windows.Forms.CheckBox cbSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbSCount;
        private SplitContainer splitContainer1;
        private TextBox txtData;
        private ChartTest.Controls.RealtimeChart realtimeChart1;
        private ToolStripMenuItem 绘制接收数据曲线ToolStripMenuItem;
    }
}
