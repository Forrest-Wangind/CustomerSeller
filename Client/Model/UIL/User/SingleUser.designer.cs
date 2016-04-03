namespace CustomerSeller.UIL.User
{
    partial class SingleUser
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tb_user_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_user_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cb_gender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dt_entryTine = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btn_submit = new DevComponents.DotNetBar.ButtonX();
            this.tb_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.gp_password = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tb_password_again = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_change_pass = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tb_extension = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.gp_role = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tree_role = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_entryTine)).BeginInit();
            this.gp_password.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gp_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(222, 96);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "用户编号：";
            // 
            // tb_user_id
            // 
            // 
            // 
            // 
            this.tb_user_id.Border.Class = "TextBoxBorder";
            this.tb_user_id.Enabled = false;
            this.tb_user_id.Location = new System.Drawing.Point(303, 97);
            this.tb_user_id.Name = "tb_user_id";
            this.tb_user_id.Size = new System.Drawing.Size(100, 21);
            this.tb_user_id.TabIndex = 1;
            // 
            // tb_user_name
            // 
            // 
            // 
            // 
            this.tb_user_name.Border.Class = "TextBoxBorder";
            this.tb_user_name.Location = new System.Drawing.Point(303, 148);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(100, 21);
            this.tb_user_name.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(222, 147);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "姓名：";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(222, 256);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "性别：";
            // 
            // cb_gender
            // 
            this.cb_gender.DisplayMember = "Text";
            this.cb_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.ItemHeight = 15;
            this.cb_gender.Location = new System.Drawing.Point(303, 259);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(121, 21);
            this.cb_gender.TabIndex = 5;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(222, 353);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "入职时间：";
            // 
            // dt_entryTine
            // 
            // 
            // 
            // 
            this.dt_entryTine.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_entryTine.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dt_entryTine.ButtonDropDown.Visible = true;
            this.dt_entryTine.Enabled = false;
            this.dt_entryTine.Location = new System.Drawing.Point(303, 356);
            // 
            // 
            // 
            this.dt_entryTine.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dt_entryTine.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dt_entryTine.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_entryTine.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_entryTine.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_entryTine.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_entryTine.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_entryTine.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_entryTine.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_entryTine.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dt_entryTine.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dt_entryTine.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dt_entryTine.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dt_entryTine.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_entryTine.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_entryTine.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_entryTine.MonthCalendar.TodayButtonVisible = true;
            this.dt_entryTine.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dt_entryTine.Name = "dt_entryTine";
            this.dt_entryTine.Size = new System.Drawing.Size(200, 21);
            this.dt_entryTine.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_submit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_submit.Location = new System.Drawing.Point(303, 448);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "提交";
            this.btn_submit.Visible = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_password
            // 
            // 
            // 
            // 
            this.tb_password.Border.Class = "TextBoxBorder";
            this.tb_password.Location = new System.Drawing.Point(212, 38);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 21);
            this.tb_password.TabIndex = 10;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(114, 38);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "密码：";
            // 
            // gp_password
            // 
            this.gp_password.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_password.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_password.Controls.Add(this.panel1);
            this.gp_password.Location = new System.Drawing.Point(550, 47);
            this.gp_password.Name = "gp_password";
            this.gp_password.Size = new System.Drawing.Size(426, 196);
            // 
            // 
            // 
            this.gp_password.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_password.Style.BackColorGradientAngle = 90;
            this.gp_password.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_password.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_password.Style.BorderBottomWidth = 1;
            this.gp_password.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_password.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_password.Style.BorderLeftWidth = 1;
            this.gp_password.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_password.Style.BorderRightWidth = 1;
            this.gp_password.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_password.Style.BorderTopWidth = 1;
            this.gp_password.Style.CornerDiameter = 4;
            this.gp_password.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_password.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_password.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_password.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gp_password.TabIndex = 11;
            this.gp_password.Text = "修改密码";
            this.gp_password.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.tb_password_again);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 172);
            this.panel1.TabIndex = 16;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(114, 84);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "确认密码：";
            // 
            // tb_password_again
            // 
            // 
            // 
            // 
            this.tb_password_again.Border.Class = "TextBoxBorder";
            this.tb_password_again.Location = new System.Drawing.Point(212, 84);
            this.tb_password_again.Name = "tb_password_again";
            this.tb_password_again.PasswordChar = '*';
            this.tb_password_again.Size = new System.Drawing.Size(100, 21);
            this.tb_password_again.TabIndex = 12;
            // 
            // cb_change_pass
            // 
            this.cb_change_pass.Location = new System.Drawing.Point(303, 203);
            this.cb_change_pass.Name = "cb_change_pass";
            this.cb_change_pass.Size = new System.Drawing.Size(121, 23);
            this.cb_change_pass.TabIndex = 13;
            this.cb_change_pass.Text = "是否修改密码？";
            this.cb_change_pass.Visible = false;
            this.cb_change_pass.CheckedChanged += new System.EventHandler(this.cb_change_pass_CheckedChanged);
            // 
            // tb_extension
            // 
            // 
            // 
            // 
            this.tb_extension.Border.Class = "TextBoxBorder";
            this.tb_extension.Enabled = false;
            this.tb_extension.Location = new System.Drawing.Point(303, 308);
            this.tb_extension.Name = "tb_extension";
            this.tb_extension.Size = new System.Drawing.Size(100, 21);
            this.tb_extension.TabIndex = 15;
            // 
            // labelX9
            // 
            this.labelX9.Location = new System.Drawing.Point(222, 307);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 14;
            this.labelX9.Text = "分机号：";
            // 
            // gp_role
            // 
            this.gp_role.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_role.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_role.Controls.Add(this.tree_role);
            this.gp_role.Location = new System.Drawing.Point(550, 256);
            this.gp_role.Name = "gp_role";
            this.gp_role.Size = new System.Drawing.Size(426, 235);
            // 
            // 
            // 
            this.gp_role.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_role.Style.BackColorGradientAngle = 90;
            this.gp_role.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_role.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_role.Style.BorderBottomWidth = 1;
            this.gp_role.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_role.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_role.Style.BorderLeftWidth = 1;
            this.gp_role.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_role.Style.BorderRightWidth = 1;
            this.gp_role.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_role.Style.BorderTopWidth = 1;
            this.gp_role.Style.CornerDiameter = 4;
            this.gp_role.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_role.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_role.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_role.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gp_role.TabIndex = 16;
            this.gp_role.Text = "修改角色";
            this.gp_role.Visible = false;
            // 
            // tree_role
            // 
            this.tree_role.CheckBoxes = true;
            this.tree_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_role.Location = new System.Drawing.Point(0, 0);
            this.tree_role.Name = "tree_role";
            this.tree_role.Size = new System.Drawing.Size(420, 211);
            this.tree_role.TabIndex = 18;
            // 
            // SingleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gp_role);
            this.Controls.Add(this.tb_extension);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.cb_change_pass);
            this.Controls.Add(this.gp_password);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dt_entryTine);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tb_user_name);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tb_user_id);
            this.Controls.Add(this.labelX1);
            this.Name = "SingleUser";
            this.Size = new System.Drawing.Size(1011, 639);
            ((System.ComponentModel.ISupportInitialize)(this.dt_entryTine)).EndInit();
            this.gp_password.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gp_role.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_user_id;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_user_name;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_gender;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_entryTine;
        private DevComponents.DotNetBar.ButtonX btn_submit;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_password;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password_again;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb_change_pass;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_extension;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_role;
        private System.Windows.Forms.TreeView tree_role;
    }
}