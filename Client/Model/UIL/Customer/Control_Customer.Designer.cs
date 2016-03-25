using TActionProject;
namespace CustomerSeller
{
    partial class Control_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgv_Customer = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_End_DealTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtp_Create_EndTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtp_Create_StartTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtp_Start_DealTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.bt_GetPhone = new DevComponents.DotNetBar.ButtonX();
            this.bt_Del = new DevComponents.DotNetBar.ButtonX();
            this.bt_Query = new DevComponents.DotNetBar.ButtonX();
            this.lb_Status = new DevComponents.DotNetBar.LabelX();
            this.lb_Success_StartTime = new DevComponents.DotNetBar.LabelX();
            this.lb_Success_EndTime = new DevComponents.DotNetBar.LabelX();
            this.lb_Create_StartTime = new DevComponents.DotNetBar.LabelX();
            this.lb_Create_EndTime = new DevComponents.DotNetBar.LabelX();
            this.lb_Customer_Name = new DevComponents.DotNetBar.LabelX();
            this.tb_Customer_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_Customer_Phone = new DevComponents.DotNetBar.LabelX();
            this.tb_Customer_Phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pagerControl1 = new TActionProject.PagerControl();
            this.cb_status = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbItemmind = new DevComponents.Editors.ComboItem();
            this.cbItemNearSuccess = new DevComponents.Editors.ComboItem();
            this.cbItemSuccess = new DevComponents.Editors.ComboItem();
            this.cbItemNoMind = new DevComponents.Editors.ComboItem();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_End_DealTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Create_EndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Create_StartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Start_DealTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dgv_Customer);
            this.panelData.Controls.Add(this.groupBox1);
            this.panelData.Controls.Add(this.pagerControl1);
            this.panelData.Location = new System.Drawing.Point(0, 3);
            this.panelData.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(912, 480);
            this.panelData.TabIndex = 19;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Customer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_Customer.Location = new System.Drawing.Point(0, 161);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowTemplate.Height = 23;
            this.dgv_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customer.Size = new System.Drawing.Size(912, 290);
            this.dgv_Customer.TabIndex = 2;
            this.dgv_Customer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Customer_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Controls.Add(this.dtp_End_DealTime);
            this.groupBox1.Controls.Add(this.dtp_Create_EndTime);
            this.groupBox1.Controls.Add(this.dtp_Create_StartTime);
            this.groupBox1.Controls.Add(this.dtp_Start_DealTime);
            this.groupBox1.Controls.Add(this.bt_GetPhone);
            this.groupBox1.Controls.Add(this.bt_Del);
            this.groupBox1.Controls.Add(this.bt_Query);
            this.groupBox1.Controls.Add(this.lb_Status);
            this.groupBox1.Controls.Add(this.lb_Success_StartTime);
            this.groupBox1.Controls.Add(this.lb_Success_EndTime);
            this.groupBox1.Controls.Add(this.lb_Create_StartTime);
            this.groupBox1.Controls.Add(this.lb_Create_EndTime);
            this.groupBox1.Controls.Add(this.lb_Customer_Name);
            this.groupBox1.Controls.Add(this.tb_Customer_Name);
            this.groupBox1.Controls.Add(this.lb_Customer_Phone);
            this.groupBox1.Controls.Add(this.tb_Customer_Phone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 161);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选条件";
            // 
            // dtp_End_DealTime
            // 
            // 
            // 
            // 
            this.dtp_End_DealTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_End_DealTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_End_DealTime.ButtonDropDown.Visible = true;
            this.dtp_End_DealTime.Location = new System.Drawing.Point(546, 64);
            // 
            // 
            // 
            this.dtp_End_DealTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_End_DealTime.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_End_DealTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_End_DealTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_End_DealTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_End_DealTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_End_DealTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_End_DealTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_End_DealTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_End_DealTime.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dtp_End_DealTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_End_DealTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_End_DealTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_End_DealTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_End_DealTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_End_DealTime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_End_DealTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_End_DealTime.Name = "dtp_End_DealTime";
            this.dtp_End_DealTime.Size = new System.Drawing.Size(106, 21);
            this.dtp_End_DealTime.TabIndex = 23;
            // 
            // dtp_Create_EndTime
            // 
            // 
            // 
            // 
            this.dtp_Create_EndTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_Create_EndTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_Create_EndTime.ButtonDropDown.Visible = true;
            this.dtp_Create_EndTime.Location = new System.Drawing.Point(766, 21);
            // 
            // 
            // 
            this.dtp_Create_EndTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_Create_EndTime.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_Create_EndTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_Create_EndTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_Create_EndTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_Create_EndTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_Create_EndTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_Create_EndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_Create_EndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_Create_EndTime.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dtp_Create_EndTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_Create_EndTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_Create_EndTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_Create_EndTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_Create_EndTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_Create_EndTime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_Create_EndTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_Create_EndTime.Name = "dtp_Create_EndTime";
            this.dtp_Create_EndTime.Size = new System.Drawing.Size(106, 21);
            this.dtp_Create_EndTime.TabIndex = 22;
            // 
            // dtp_Create_StartTime
            // 
            // 
            // 
            // 
            this.dtp_Create_StartTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_Create_StartTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_Create_StartTime.ButtonDropDown.Visible = true;
            this.dtp_Create_StartTime.Location = new System.Drawing.Point(546, 21);
            // 
            // 
            // 
            this.dtp_Create_StartTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_Create_StartTime.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_Create_StartTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_Create_StartTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_Create_StartTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_Create_StartTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_Create_StartTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_Create_StartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_Create_StartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_Create_StartTime.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dtp_Create_StartTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_Create_StartTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_Create_StartTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_Create_StartTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_Create_StartTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_Create_StartTime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_Create_StartTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_Create_StartTime.Name = "dtp_Create_StartTime";
            this.dtp_Create_StartTime.Size = new System.Drawing.Size(106, 21);
            this.dtp_Create_StartTime.TabIndex = 21;
            // 
            // dtp_Start_DealTime
            // 
            // 
            // 
            // 
            this.dtp_Start_DealTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_Start_DealTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_Start_DealTime.ButtonDropDown.Visible = true;
            this.dtp_Start_DealTime.Location = new System.Drawing.Point(311, 64);
            // 
            // 
            // 
            this.dtp_Start_DealTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_Start_DealTime.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_Start_DealTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_Start_DealTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_Start_DealTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_Start_DealTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_Start_DealTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_Start_DealTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_Start_DealTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_Start_DealTime.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dtp_Start_DealTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_Start_DealTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_Start_DealTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_Start_DealTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_Start_DealTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_Start_DealTime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_Start_DealTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_Start_DealTime.Name = "dtp_Start_DealTime";
            this.dtp_Start_DealTime.Size = new System.Drawing.Size(106, 21);
            this.dtp_Start_DealTime.TabIndex = 20;
            // 
            // bt_GetPhone
            // 
            this.bt_GetPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_GetPhone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_GetPhone.Location = new System.Drawing.Point(278, 113);
            this.bt_GetPhone.Name = "bt_GetPhone";
            this.bt_GetPhone.Size = new System.Drawing.Size(75, 23);
            this.bt_GetPhone.TabIndex = 19;
            this.bt_GetPhone.Text = "取电话";
            this.bt_GetPhone.Click += new System.EventHandler(this.bt_GetPhone_Click);
            // 
            // bt_Del
            // 
            this.bt_Del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Del.Location = new System.Drawing.Point(141, 113);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(75, 23);
            this.bt_Del.TabIndex = 13;
            this.bt_Del.Text = "清空";
            this.bt_Del.Click += new System.EventHandler(this.bt_Del_Click);
            // 
            // bt_Query
            // 
            this.bt_Query.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Query.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Query.Location = new System.Drawing.Point(18, 113);
            this.bt_Query.Name = "bt_Query";
            this.bt_Query.Size = new System.Drawing.Size(75, 23);
            this.bt_Query.TabIndex = 12;
            this.bt_Query.Text = "查询";
            this.bt_Query.Click += new System.EventHandler(this.bt_Query_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.Location = new System.Drawing.Point(20, 65);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(67, 21);
            this.lb_Status.TabIndex = 17;
            this.lb_Status.Text = "成交状态:";
            // 
            // lb_Success_StartTime
            // 
            this.lb_Success_StartTime.Location = new System.Drawing.Point(229, 65);
            this.lb_Success_StartTime.Name = "lb_Success_StartTime";
            this.lb_Success_StartTime.Size = new System.Drawing.Size(87, 21);
            this.lb_Success_StartTime.TabIndex = 11;
            this.lb_Success_StartTime.Text = "成交开始时间:";
            // 
            // lb_Success_EndTime
            // 
            this.lb_Success_EndTime.Location = new System.Drawing.Point(442, 60);
            this.lb_Success_EndTime.Name = "lb_Success_EndTime";
            this.lb_Success_EndTime.Size = new System.Drawing.Size(99, 33);
            this.lb_Success_EndTime.TabIndex = 12;
            this.lb_Success_EndTime.Text = "成交截止时间：";
            // 
            // lb_Create_StartTime
            // 
            this.lb_Create_StartTime.Location = new System.Drawing.Point(442, 20);
            this.lb_Create_StartTime.Name = "lb_Create_StartTime";
            this.lb_Create_StartTime.Size = new System.Drawing.Size(98, 21);
            this.lb_Create_StartTime.TabIndex = 11;
            this.lb_Create_StartTime.Text = "获取开始时间:";
            // 
            // lb_Create_EndTime
            // 
            this.lb_Create_EndTime.Location = new System.Drawing.Point(677, 11);
            this.lb_Create_EndTime.Name = "lb_Create_EndTime";
            this.lb_Create_EndTime.Size = new System.Drawing.Size(99, 33);
            this.lb_Create_EndTime.TabIndex = 12;
            this.lb_Create_EndTime.Text = "获取截止时间：";
            // 
            // lb_Customer_Name
            // 
            this.lb_Customer_Name.Location = new System.Drawing.Point(20, 20);
            this.lb_Customer_Name.Name = "lb_Customer_Name";
            this.lb_Customer_Name.Size = new System.Drawing.Size(67, 21);
            this.lb_Customer_Name.TabIndex = 0;
            this.lb_Customer_Name.Text = "客户姓名:";
            // 
            // tb_Customer_Name
            // 
            // 
            // 
            // 
            this.tb_Customer_Name.Border.Class = "TextBoxBorder";
            this.tb_Customer_Name.Location = new System.Drawing.Point(93, 20);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(123, 21);
            this.tb_Customer_Name.TabIndex = 8;
            // 
            // lb_Customer_Phone
            // 
            this.lb_Customer_Phone.Location = new System.Drawing.Point(229, 14);
            this.lb_Customer_Phone.Name = "lb_Customer_Phone";
            this.lb_Customer_Phone.Size = new System.Drawing.Size(64, 33);
            this.lb_Customer_Phone.TabIndex = 4;
            this.lb_Customer_Phone.Text = "客户手机:";
            // 
            // tb_Customer_Phone
            // 
            // 
            // 
            // 
            this.tb_Customer_Phone.Border.Class = "TextBoxBorder";
            this.tb_Customer_Phone.Location = new System.Drawing.Point(311, 20);
            this.tb_Customer_Phone.Name = "tb_Customer_Phone";
            this.tb_Customer_Phone.Size = new System.Drawing.Size(105, 21);
            this.tb_Customer_Phone.TabIndex = 10;
            // 
            // pagerControl1
            // 
            this.pagerControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pagerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagerControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl1.JumpText = "Go";
            this.pagerControl1.Location = new System.Drawing.Point(0, 451);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 100;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(912, 29);
            this.pagerControl1.TabIndex = 1;
            // 
            // cb_status
            // 
            this.cb_status.DisplayMember = "Text";
            this.cb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.ItemHeight = 15;
            this.cb_status.Items.AddRange(new object[] {
            this.cbItemmind,
            this.cbItemNearSuccess,
            this.cbItemSuccess,
            this.cbItemNoMind});
            this.cb_status.Location = new System.Drawing.Point(93, 65);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(123, 21);
            this.cb_status.TabIndex = 24;
            // 
            // cbItemmind
            // 
            this.cbItemmind.Text = "有意向";
            // 
            // cbItemNearSuccess
            // 
            this.cbItemNearSuccess.Text = "预成交";
            // 
            // cbItemSuccess
            // 
            this.cbItemSuccess.Text = "已成交";
            // 
            // cbItemNoMind
            // 
            this.cbItemNoMind.Text = "无意向";
            // 
            // Control_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelData);
            this.Name = "Control_Customer";
            this.Size = new System.Drawing.Size(916, 515);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_End_DealTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Create_EndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Create_StartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Start_DealTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Customer;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_End_DealTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_Create_EndTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_Create_StartTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_Start_DealTime;
        private DevComponents.DotNetBar.ButtonX bt_GetPhone;
        private DevComponents.DotNetBar.ButtonX bt_Del;
        private DevComponents.DotNetBar.ButtonX bt_Query;
        private DevComponents.DotNetBar.LabelX lb_Status;
        private DevComponents.DotNetBar.LabelX lb_Success_StartTime;
        private DevComponents.DotNetBar.LabelX lb_Success_EndTime;
        private DevComponents.DotNetBar.LabelX lb_Create_StartTime;
        private DevComponents.DotNetBar.LabelX lb_Create_EndTime;
        private DevComponents.DotNetBar.LabelX lb_Customer_Name;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Customer_Name;
        private DevComponents.DotNetBar.LabelX lb_Customer_Phone;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Customer_Phone;
        private PagerControl pagerControl1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_status;
        private DevComponents.Editors.ComboItem cbItemmind;
        private DevComponents.Editors.ComboItem cbItemNearSuccess;
        private DevComponents.Editors.ComboItem cbItemSuccess;
        private DevComponents.Editors.ComboItem cbItemNoMind;








    }
}
