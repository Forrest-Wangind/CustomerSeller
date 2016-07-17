namespace CustomerSeller.UIL
{
    partial class PhoneParamSetting
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tb_PhoneTotalNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_DailyPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bt_save = new DevComponents.DotNetBar.ButtonX();
            this.bt_clear = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxExPhoneType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemA = new DevComponents.Editors.ComboItem();
            this.comboItemB = new DevComponents.Editors.ComboItem();
            this.comboItemC = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbUserId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbPhoneType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_phone_detail = new System.Windows.Forms.DataGridView();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_phone_general = new System.Windows.Forms.DataGridView();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tbUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbGroup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblGroup = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phone_detail)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phone_general)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(125, 76);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(120, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "业务可取电话总数：";
            // 
            // tb_PhoneTotalNumber
            // 
            // 
            // 
            // 
            this.tb_PhoneTotalNumber.Border.Class = "TextBoxBorder";
            this.tb_PhoneTotalNumber.Location = new System.Drawing.Point(265, 80);
            this.tb_PhoneTotalNumber.Name = "tb_PhoneTotalNumber";
            this.tb_PhoneTotalNumber.Size = new System.Drawing.Size(139, 21);
            this.tb_PhoneTotalNumber.TabIndex = 1;
            // 
            // tb_DailyPhoneNumber
            // 
            // 
            // 
            // 
            this.tb_DailyPhoneNumber.Border.Class = "TextBoxBorder";
            this.tb_DailyPhoneNumber.Location = new System.Drawing.Point(265, 132);
            this.tb_DailyPhoneNumber.Name = "tb_DailyPhoneNumber";
            this.tb_DailyPhoneNumber.Size = new System.Drawing.Size(139, 21);
            this.tb_DailyPhoneNumber.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(125, 128);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(130, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "业务每天可取电话量：";
            // 
            // bt_save
            // 
            this.bt_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_save.Location = new System.Drawing.Point(170, 193);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "保存";
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_clear.Location = new System.Drawing.Point(294, 193);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "清空";
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // comboBoxExPhoneType
            // 
            this.comboBoxExPhoneType.DisplayMember = "Text";
            this.comboBoxExPhoneType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxExPhoneType.FormattingEnabled = true;
            this.comboBoxExPhoneType.ItemHeight = 15;
            this.comboBoxExPhoneType.Items.AddRange(new object[] {
            this.comboItemA,
            this.comboItemB,
            this.comboItemC});
            this.comboBoxExPhoneType.Location = new System.Drawing.Point(265, 33);
            this.comboBoxExPhoneType.Name = "comboBoxExPhoneType";
            this.comboBoxExPhoneType.Size = new System.Drawing.Size(139, 21);
            this.comboBoxExPhoneType.TabIndex = 5;
            // 
            // comboItemA
            // 
            this.comboItemA.Text = "A类型电话";
            // 
            // comboItemB
            // 
            this.comboItemB.Text = "B类型电话";
            // 
            // comboItemC
            // 
            this.comboItemC.Text = "C类型电话";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(125, 31);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "电话类型:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 265);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbGroup);
            this.panel4.Controls.Add(this.lblGroup);
            this.panel4.Controls.Add(this.labelX6);
            this.panel4.Controls.Add(this.tbUserName);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Controls.Add(this.labelX5);
            this.panel4.Controls.Add(this.tbUserId);
            this.panel4.Controls.Add(this.labelX4);
            this.panel4.Controls.Add(this.cbPhoneType);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(557, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 265);
            this.panel4.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Location = new System.Drawing.Point(283, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "查询";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(175, 81);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(85, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "员工编号：";
            // 
            // tbUserId
            // 
            // 
            // 
            // 
            this.tbUserId.Border.Class = "TextBoxBorder";
            this.tbUserId.Location = new System.Drawing.Point(283, 80);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(139, 21);
            this.tbUserId.TabIndex = 10;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(175, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "电话类型:";
            // 
            // cbPhoneType
            // 
            this.cbPhoneType.DisplayMember = "Text";
            this.cbPhoneType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhoneType.FormattingEnabled = true;
            this.cbPhoneType.ItemHeight = 15;
            this.cbPhoneType.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cbPhoneType.Location = new System.Drawing.Point(283, 33);
            this.cbPhoneType.Name = "cbPhoneType";
            this.cbPhoneType.Size = new System.Drawing.Size(139, 21);
            this.cbPhoneType.TabIndex = 7;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "A类型电话";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "B类型电话";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "C类型电话";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelX1);
            this.panel3.Controls.Add(this.bt_save);
            this.panel3.Controls.Add(this.labelX3);
            this.panel3.Controls.Add(this.tb_DailyPhoneNumber);
            this.panel3.Controls.Add(this.tb_PhoneTotalNumber);
            this.panel3.Controls.Add(this.bt_clear);
            this.panel3.Controls.Add(this.comboBoxExPhoneType);
            this.panel3.Controls.Add(this.labelX2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 265);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupPanel2);
            this.panel2.Controls.Add(this.groupPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 519);
            this.panel2.TabIndex = 8;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dgv_phone_detail);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(557, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(622, 519);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "分配明细";
            // 
            // dgv_phone_detail
            // 
            this.dgv_phone_detail.AllowUserToAddRows = false;
            this.dgv_phone_detail.AllowUserToDeleteRows = false;
            this.dgv_phone_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_phone_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phone_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phone_detail.Location = new System.Drawing.Point(0, 0);
            this.dgv_phone_detail.Name = "dgv_phone_detail";
            this.dgv_phone_detail.RowTemplate.Height = 23;
            this.dgv_phone_detail.Size = new System.Drawing.Size(616, 495);
            this.dgv_phone_detail.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgv_phone_general);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(557, 519);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "分配规则";
            // 
            // dgv_phone_general
            // 
            this.dgv_phone_general.AllowUserToAddRows = false;
            this.dgv_phone_general.AllowUserToDeleteRows = false;
            this.dgv_phone_general.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_phone_general.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phone_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phone_general.Location = new System.Drawing.Point(0, 0);
            this.dgv_phone_general.Name = "dgv_phone_general";
            this.dgv_phone_general.RowTemplate.Height = 23;
            this.dgv_phone_general.Size = new System.Drawing.Size(551, 495);
            this.dgv_phone_general.TabIndex = 0;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(175, 131);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(85, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "员工姓名：";
            // 
            // tbUserName
            // 
            // 
            // 
            // 
            this.tbUserName.Border.Class = "TextBoxBorder";
            this.tbUserName.Location = new System.Drawing.Point(283, 132);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(139, 21);
            this.tbUserName.TabIndex = 13;
            // 
            // cbGroup
            // 
            this.cbGroup.DisplayMember = "Text";
            this.cbGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.ItemHeight = 15;
            this.cbGroup.Location = new System.Drawing.Point(283, 184);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(200, 21);
            this.cbGroup.TabIndex = 32;
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(175, 184);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(75, 23);
            this.lblGroup.TabIndex = 31;
            this.lblGroup.Text = "销售部门：";
            // 
            // PhoneParamSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhoneParamSetting";
            this.Size = new System.Drawing.Size(1179, 784);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phone_detail)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phone_general)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_PhoneTotalNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_DailyPhoneNumber;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX bt_save;
        private DevComponents.DotNetBar.ButtonX bt_clear;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxExPhoneType;
        private DevComponents.Editors.ComboItem comboItemA;
        private DevComponents.Editors.ComboItem comboItemB;
        private DevComponents.Editors.ComboItem comboItemC;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_phone_detail;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.ButtonX btnSubmit;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUserId;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbPhoneType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_phone_general;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUserName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbGroup;
        private DevComponents.DotNetBar.LabelX lblGroup;
    }
}
