namespace CustomerSeller
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.sideBarPanelItem1 = new DevComponents.DotNetBar.SideBarPanelItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Date_label = new DevComponents.DotNetBar.LabelX();
            this.Time = new System.Windows.Forms.Panel();
            this.Time_label = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Put_panel = new System.Windows.Forms.Panel();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sideBar1 = new DevComponents.DotNetBar.SideBar();
            this.user_ManageMent = new DevComponents.DotNetBar.SideBarPanelItem();
            this.AllUsers = new DevComponents.DotNetBar.ButtonItem();
            this.singleUser = new DevComponents.DotNetBar.ButtonItem();
            this.AddUser = new DevComponents.DotNetBar.ButtonItem();
            this.btn_update_user = new DevComponents.DotNetBar.ButtonItem();
            this.btitemPhoneParams = new DevComponents.DotNetBar.ButtonItem();
            this.Customer_Management = new DevComponents.DotNetBar.SideBarPanelItem();
            this.Query_CustomerInfo = new DevComponents.DotNetBar.ButtonItem();
            this.Add_CustomerInfo = new DevComponents.DotNetBar.ButtonItem();
            this.Import_CustomerInfo = new DevComponents.DotNetBar.ButtonItem();
            this.RoleManagement = new DevComponents.DotNetBar.SideBarPanelItem();
            this.AllRoles = new DevComponents.DotNetBar.ButtonItem();
            this.RoleDetail = new DevComponents.DotNetBar.ButtonItem();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Put_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanelItem1
            // 
            this.sideBarPanelItem1.FontBold = true;
            this.sideBarPanelItem1.Name = "sideBarPanelItem1";
            this.sideBarPanelItem1.Text = "订单跟踪管理";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 95);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.ForeColor = System.Drawing.SystemColors.Window;
            this.panel6.Location = new System.Drawing.Point(741, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(182, 95);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(63, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "退出";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "首页";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(16, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(37, 48);
            this.panel8.TabIndex = 2;
            this.panel8.Click += new System.EventHandler(this.Main_panel_Click);
            this.panel8.MouseEnter += new System.EventHandler(this.panel8_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(64, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(36, 48);
            this.panel9.TabIndex = 5;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            this.panel9.MouseEnter += new System.EventHandler(this.panel9_MouseEnter);
            this.panel9.MouseLeave += new System.EventHandler(this.panel9_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(110, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "注销";
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(111, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(39, 49);
            this.panel7.TabIndex = 0;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            this.panel7.MouseEnter += new System.EventHandler(this.panel7_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter1.Enabled = false;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 95);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(923, 10);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 1;
            this.expandableSplitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Date_label);
            this.panel3.Controls.Add(this.Time);
            this.panel3.Controls.Add(this.Time_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 27);
            this.panel3.TabIndex = 2;
            // 
            // Date_label
            // 
            this.Date_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Date_label.Location = new System.Drawing.Point(651, 0);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(160, 23);
            this.Date_label.TabIndex = 2;
            this.Date_label.Text = "当前时间：            ";
            // 
            // Time
            // 
            this.Time.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Time.BackgroundImage")));
            this.Time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.Time.Location = new System.Drawing.Point(811, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(37, 23);
            this.Time.TabIndex = 1;
            // 
            // Time_label
            // 
            this.Time_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Time_label.Location = new System.Drawing.Point(848, 0);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(71, 23);
            this.Time_label.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Put_panel);
            this.panel1.Controls.Add(this.expandableSplitter2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.expandableSplitter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 508);
            this.panel1.TabIndex = 0;
            // 
            // Put_panel
            // 
            this.Put_panel.Controls.Add(this.Main_panel);
            this.Put_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Put_panel.Location = new System.Drawing.Point(180, 105);
            this.Put_panel.Name = "Put_panel";
            this.Put_panel.Size = new System.Drawing.Size(743, 376);
            this.Put_panel.TabIndex = 5;
            // 
            // Main_panel
            // 
            this.Main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(743, 376);
            this.Main_panel.TabIndex = 6;
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(170, 105);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(10, 376);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 4;
            this.expandableSplitter2.TabStop = false;
            this.expandableSplitter2.Click += new System.EventHandler(this.expandableSplitter2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sideBar1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 376);
            this.panel4.TabIndex = 3;
            // 
            // sideBar1
            // 
            this.sideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.sideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None;
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBar1.ExpandedPanel = this.user_ManageMent;
            this.sideBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Panels.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Customer_Management,
            this.user_ManageMent,
            this.RoleManagement});
            this.sideBar1.Size = new System.Drawing.Size(170, 376);
            this.sideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.sideBar1.TabIndex = 0;
            this.sideBar1.Text = "删除用户";
            // 
            // user_ManageMent
            // 
            this.user_ManageMent.FontBold = true;
            this.user_ManageMent.Icon = ((System.Drawing.Icon)(resources.GetObject("user_ManageMent.Icon")));
            this.user_ManageMent.Name = "user_ManageMent";
            this.user_ManageMent.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.AllUsers,
            this.singleUser,
            this.AddUser,
            this.btn_update_user,
            this.btitemPhoneParams});
            this.user_ManageMent.Text = "用户信息管理";
            this.user_ManageMent.Visible = false;
            // 
            // AllUsers
            // 
            this.AllUsers.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.AllUsers.ImagePaddingHorizontal = 8;
            this.AllUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.Text = "所有用户";
            this.AllUsers.Visible = false;
            this.AllUsers.Click += new System.EventHandler(this.AllUsers_Click);
            // 
            // singleUser
            // 
            this.singleUser.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.singleUser.ImagePaddingHorizontal = 8;
            this.singleUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.singleUser.Name = "singleUser";
            this.singleUser.Text = "当前用户";
            this.singleUser.Click += new System.EventHandler(this.singleUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.AddUser.ImagePaddingHorizontal = 8;
            this.AddUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.AddUser.Name = "AddUser";
            this.AddUser.Text = "添加用户";
            this.AddUser.Visible = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // btn_update_user
            // 
            this.btn_update_user.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_update_user.ImagePaddingHorizontal = 8;
            this.btn_update_user.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_update_user.Name = "btn_update_user";
            this.btn_update_user.Text = "修改用户";
            this.btn_update_user.Click += new System.EventHandler(this.btn_update_user_Click);
            // 
            // btitemPhoneParams
            // 
            this.btitemPhoneParams.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btitemPhoneParams.ImagePaddingHorizontal = 8;
            this.btitemPhoneParams.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btitemPhoneParams.Name = "btitemPhoneParams";
            this.btitemPhoneParams.Text = "修改电话分配数量";
            this.btitemPhoneParams.Visible = false;
            this.btitemPhoneParams.Click += new System.EventHandler(this.btitemPhoneParams_Click);
            // 
            // Customer_Management
            // 
            this.Customer_Management.FontBold = true;
            this.Customer_Management.Icon = ((System.Drawing.Icon)(resources.GetObject("Customer_Management.Icon")));
            this.Customer_Management.Name = "Customer_Management";
            this.Customer_Management.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Query_CustomerInfo,
            this.Add_CustomerInfo,
            this.Import_CustomerInfo});
            this.Customer_Management.Text = "客户信息管理";
            this.Customer_Management.Visible = false;
            // 
            // Query_CustomerInfo
            // 
            this.Query_CustomerInfo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Query_CustomerInfo.ImagePaddingHorizontal = 8;
            this.Query_CustomerInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.Query_CustomerInfo.Name = "Query_CustomerInfo";
            this.Query_CustomerInfo.Text = "查询客户数据";
            this.Query_CustomerInfo.Click += new System.EventHandler(this.Query_CustomerInfo_Click);
            // 
            // Add_CustomerInfo
            // 
            this.Add_CustomerInfo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Add_CustomerInfo.ImagePaddingHorizontal = 8;
            this.Add_CustomerInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.Add_CustomerInfo.Name = "Add_CustomerInfo";
            this.Add_CustomerInfo.Text = "新增客户数据";
            this.Add_CustomerInfo.Click += new System.EventHandler(this.Add_CustomerInfo_Click);
            // 
            // Import_CustomerInfo
            // 
            this.Import_CustomerInfo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Import_CustomerInfo.ImagePaddingHorizontal = 8;
            this.Import_CustomerInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.Import_CustomerInfo.Name = "Import_CustomerInfo";
            this.Import_CustomerInfo.Text = "导入客户数据";
            this.Import_CustomerInfo.Click += new System.EventHandler(this.Import_CustomerInfo_Click);
            // 
            // RoleManagement
            // 
            this.RoleManagement.FontBold = true;
            this.RoleManagement.Name = "RoleManagement";
            this.RoleManagement.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.AllRoles,
            this.RoleDetail});
            this.RoleManagement.Text = "角色管理";
            this.RoleManagement.Visible = false;
            // 
            // AllRoles
            // 
            this.AllRoles.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.AllRoles.ImagePaddingHorizontal = 8;
            this.AllRoles.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.AllRoles.Name = "AllRoles";
            this.AllRoles.Text = "所有角色";
            this.AllRoles.Click += new System.EventHandler(this.AllRoles_Click);
            // 
            // RoleDetail
            // 
            this.RoleDetail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.RoleDetail.ImagePaddingHorizontal = 8;
            this.RoleDetail.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.RoleDetail.Name = "RoleDetail";
            this.RoleDetail.Text = "角色明细";
            this.RoleDetail.Click += new System.EventHandler(this.RoleDetail_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 508);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "客户销售管理系统--主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Put_panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SideBarPanelItem sideBarPanelItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.LabelX Date_label;
        private System.Windows.Forms.Panel Time;
        private DevComponents.DotNetBar.LabelX Time_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Put_panel;
        private System.Windows.Forms.Panel Main_panel;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.SideBar sideBar1;
        private DevComponents.DotNetBar.SideBarPanelItem user_ManageMent;
        private DevComponents.DotNetBar.SideBarPanelItem Customer_Management;
        private DevComponents.DotNetBar.ButtonItem Query_CustomerInfo;
        private DevComponents.DotNetBar.ButtonItem Add_CustomerInfo;
        private DevComponents.DotNetBar.ButtonItem Import_CustomerInfo;
        private DevComponents.DotNetBar.ButtonItem AllUsers;
        private DevComponents.DotNetBar.SideBarPanelItem RoleManagement;
        private DevComponents.DotNetBar.ButtonItem singleUser;
        private DevComponents.DotNetBar.ButtonItem AddUser;
        private DevComponents.DotNetBar.ButtonItem btn_update_user;
        private DevComponents.DotNetBar.ButtonItem AllRoles;
        private DevComponents.DotNetBar.ButtonItem RoleDetail;
        private DevComponents.DotNetBar.ButtonItem btitemPhoneParams;
    }
}

