namespace CustomerSeller.UIL
{
    partial class Form_CustomerDetail
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
            this.bt_Save = new DevComponents.DotNetBar.ButtonX();
            this.bt_Cancer = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Remark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtp_SuccessTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cb_PhoneStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemNearSuccess = new DevComponents.Editors.ComboItem();
            this.comboItemAlreadySuccess = new DevComponents.Editors.ComboItem();
            this.comboItemMind = new DevComponents.Editors.ComboItem();
            this.comboItemNoMind = new DevComponents.Editors.ComboItem();
            this.tb_CustomerAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_CustomerPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_Agender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemMen = new DevComponents.Editors.ComboItem();
            this.comboItemWomen = new DevComponents.Editors.ComboItem();
            this.tb_CustomerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_CallPhone = new DevComponents.DotNetBar.ButtonX();
            this.bt_RecycleCustomerPhone = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_SuccessTime)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Save.Location = new System.Drawing.Point(114, 4);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 14;
            this.bt_Save.Text = "保存";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Cancer
            // 
            this.bt_Cancer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Cancer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Cancer.Location = new System.Drawing.Point(219, 4);
            this.bt_Cancer.Name = "bt_Cancer";
            this.bt_Cancer.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancer.TabIndex = 15;
            this.bt_Cancer.Text = "清空";
            this.bt_Cancer.Click += new System.EventHandler(this.bt_Cancer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_Remark);
            this.panel1.Controls.Add(this.dtp_SuccessTime);
            this.panel1.Controls.Add(this.cb_PhoneStatus);
            this.panel1.Controls.Add(this.tb_CustomerAddress);
            this.panel1.Controls.Add(this.tb_CustomerPhone);
            this.panel1.Controls.Add(this.tb_Agender);
            this.panel1.Controls.Add(this.tb_CustomerName);
            this.panel1.Controls.Add(this.labelX7);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 338);
            this.panel1.TabIndex = 16;
            // 
            // tb_Remark
            // 
            // 
            // 
            // 
            this.tb_Remark.Border.Class = "TextBoxBorder";
            this.tb_Remark.Location = new System.Drawing.Point(491, 34);
            this.tb_Remark.Multiline = true;
            this.tb_Remark.Name = "tb_Remark";
            this.tb_Remark.Size = new System.Drawing.Size(356, 221);
            this.tb_Remark.TabIndex = 40;
            // 
            // dtp_SuccessTime
            // 
            // 
            // 
            // 
            this.dtp_SuccessTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_SuccessTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_SuccessTime.ButtonDropDown.Visible = true;
            this.dtp_SuccessTime.Location = new System.Drawing.Point(115, 233);
            // 
            // 
            // 
            this.dtp_SuccessTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_SuccessTime.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_SuccessTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_SuccessTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_SuccessTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_SuccessTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_SuccessTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_SuccessTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_SuccessTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_SuccessTime.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dtp_SuccessTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_SuccessTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_SuccessTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_SuccessTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_SuccessTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_SuccessTime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_SuccessTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_SuccessTime.Name = "dtp_SuccessTime";
            this.dtp_SuccessTime.Size = new System.Drawing.Size(176, 21);
            this.dtp_SuccessTime.TabIndex = 39;
            // 
            // cb_PhoneStatus
            // 
            this.cb_PhoneStatus.DisplayMember = "Text";
            this.cb_PhoneStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_PhoneStatus.FormattingEnabled = true;
            this.cb_PhoneStatus.ItemHeight = 15;
            this.cb_PhoneStatus.Items.AddRange(new object[] {
            this.comboItemNearSuccess,
            this.comboItemAlreadySuccess,
            this.comboItemMind,
            this.comboItemNoMind});
            this.cb_PhoneStatus.Location = new System.Drawing.Point(114, 182);
            this.cb_PhoneStatus.Name = "cb_PhoneStatus";
            this.cb_PhoneStatus.Size = new System.Drawing.Size(176, 21);
            this.cb_PhoneStatus.TabIndex = 38;
            // 
            // comboItemNearSuccess
            // 
            this.comboItemNearSuccess.Text = "预成交";
            // 
            // comboItemAlreadySuccess
            // 
            this.comboItemAlreadySuccess.Text = "已成交";
            // 
            // comboItemMind
            // 
            this.comboItemMind.Text = "有意向";
            // 
            // comboItemNoMind
            // 
            this.comboItemNoMind.Text = "无意向";
            // 
            // tb_CustomerAddress
            // 
            // 
            // 
            // 
            this.tb_CustomerAddress.Border.Class = "TextBoxBorder";
            this.tb_CustomerAddress.Location = new System.Drawing.Point(115, 145);
            this.tb_CustomerAddress.Name = "tb_CustomerAddress";
            this.tb_CustomerAddress.Size = new System.Drawing.Size(176, 21);
            this.tb_CustomerAddress.TabIndex = 37;
            // 
            // tb_CustomerPhone
            // 
            // 
            // 
            // 
            this.tb_CustomerPhone.Border.Class = "TextBoxBorder";
            this.tb_CustomerPhone.Location = new System.Drawing.Point(115, 105);
            this.tb_CustomerPhone.Name = "tb_CustomerPhone";
            this.tb_CustomerPhone.Size = new System.Drawing.Size(176, 21);
            this.tb_CustomerPhone.TabIndex = 36;
            // 
            // tb_Agender
            // 
            this.tb_Agender.DisplayMember = "Text";
            this.tb_Agender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tb_Agender.FormattingEnabled = true;
            this.tb_Agender.ItemHeight = 15;
            this.tb_Agender.Items.AddRange(new object[] {
            this.comboItemMen,
            this.comboItemWomen});
            this.tb_Agender.Location = new System.Drawing.Point(115, 66);
            this.tb_Agender.Name = "tb_Agender";
            this.tb_Agender.Size = new System.Drawing.Size(176, 21);
            this.tb_Agender.TabIndex = 35;
            // 
            // comboItemMen
            // 
            this.comboItemMen.Text = "男";
            // 
            // comboItemWomen
            // 
            this.comboItemWomen.Text = "女";
            // 
            // tb_CustomerName
            // 
            // 
            // 
            // 
            this.tb_CustomerName.Border.Class = "TextBoxBorder";
            this.tb_CustomerName.Location = new System.Drawing.Point(115, 27);
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.Size = new System.Drawing.Size(176, 21);
            this.tb_CustomerName.TabIndex = 34;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(427, 29);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(58, 23);
            this.labelX7.TabIndex = 33;
            this.labelX7.Text = "备注：";
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(20, 232);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 33;
            this.labelX6.Text = "成交时间：";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(20, 182);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 32;
            this.labelX5.Text = "电话状态：";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(20, 141);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 31;
            this.labelX4.Text = "客户地址：";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(22, 101);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(73, 23);
            this.labelX3.TabIndex = 30;
            this.labelX3.Text = "客户电话：";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(20, 66);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "客户性别：";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(22, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 28;
            this.labelX1.Text = "客户姓名：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_CallPhone);
            this.panel2.Controls.Add(this.bt_Save);
            this.panel2.Controls.Add(this.bt_RecycleCustomerPhone);
            this.panel2.Controls.Add(this.bt_Cancer);
            this.panel2.Location = new System.Drawing.Point(12, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 33);
            this.panel2.TabIndex = 17;
            // 
            // bt_CallPhone
            // 
            this.bt_CallPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_CallPhone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_CallPhone.Location = new System.Drawing.Point(13, 4);
            this.bt_CallPhone.Name = "bt_CallPhone";
            this.bt_CallPhone.Size = new System.Drawing.Size(75, 23);
            this.bt_CallPhone.TabIndex = 17;
            this.bt_CallPhone.Text = "拨打电话";
            this.bt_CallPhone.Click += new System.EventHandler(this.bt_CallPhone_Click);
            // 
            // bt_RecycleCustomerPhone
            // 
            this.bt_RecycleCustomerPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_RecycleCustomerPhone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_RecycleCustomerPhone.Location = new System.Drawing.Point(325, 4);
            this.bt_RecycleCustomerPhone.Name = "bt_RecycleCustomerPhone";
            this.bt_RecycleCustomerPhone.Size = new System.Drawing.Size(75, 23);
            this.bt_RecycleCustomerPhone.TabIndex = 15;
            this.bt_RecycleCustomerPhone.Text = "回收电话";
            this.bt_RecycleCustomerPhone.Click += new System.EventHandler(this.bt_RecycleCustomerPhone_Click);
            // 
            // Form_CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form_CustomerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "客户信息的详细界面";
            this.Load += new System.EventHandler(this.Form_CustomerDetail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_SuccessTime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX bt_Save;
        private DevComponents.DotNetBar.ButtonX bt_Cancer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX bt_CallPhone;
        private DevComponents.DotNetBar.ButtonX bt_RecycleCustomerPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_CustomerName;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Remark;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_SuccessTime;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_PhoneStatus;
        private DevComponents.Editors.ComboItem comboItemNearSuccess;
        private DevComponents.Editors.ComboItem comboItemAlreadySuccess;
        private DevComponents.Editors.ComboItem comboItemMind;
        private DevComponents.Editors.ComboItem comboItemNoMind;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_CustomerAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_CustomerPhone;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tb_Agender;
        private DevComponents.Editors.ComboItem comboItemMen;
        private DevComponents.Editors.ComboItem comboItemWomen;

    }
}