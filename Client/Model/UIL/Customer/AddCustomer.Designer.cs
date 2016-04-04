namespace CustomerSeller.UIL
{
    partial class AddCustomer
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
            this.bt_Del = new DevComponents.DotNetBar.ButtonX();
            this.bt_Save = new DevComponents.DotNetBar.ButtonX();
            this.lb_Customer_Name = new DevComponents.DotNetBar.LabelX();
            this.tb_Customer_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_Customer_Phone = new DevComponents.DotNetBar.LabelX();
            this.tb_CustomerPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tb_CustomerAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cb_Agender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemMen = new DevComponents.Editors.ComboItem();
            this.comboItemWomen = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxExPhoneType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemA = new DevComponents.Editors.ComboItem();
            this.comboItemB = new DevComponents.Editors.ComboItem();
            this.comboItemC = new DevComponents.Editors.ComboItem();
            this.SuspendLayout();
            // 
            // bt_Del
            // 
            this.bt_Del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Del.Location = new System.Drawing.Point(386, 304);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(75, 23);
            this.bt_Del.TabIndex = 28;
            this.bt_Del.Text = "清空";
            this.bt_Del.Click += new System.EventHandler(this.bt_Del_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Save.Location = new System.Drawing.Point(227, 304);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 25;
            this.bt_Save.Text = "保存";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // lb_Customer_Name
            // 
            this.lb_Customer_Name.Location = new System.Drawing.Point(23, 34);
            this.lb_Customer_Name.Name = "lb_Customer_Name";
            this.lb_Customer_Name.Size = new System.Drawing.Size(79, 21);
            this.lb_Customer_Name.TabIndex = 19;
            this.lb_Customer_Name.Text = "客户姓名:";
            // 
            // tb_Customer_Name
            // 
            // 
            // 
            // 
            this.tb_Customer_Name.Border.Class = "TextBoxBorder";
            this.tb_Customer_Name.Location = new System.Drawing.Point(117, 34);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(194, 21);
            this.tb_Customer_Name.TabIndex = 21;
            // 
            // lb_Customer_Phone
            // 
            this.lb_Customer_Phone.Location = new System.Drawing.Point(47, 69);
            this.lb_Customer_Phone.Name = "lb_Customer_Phone";
            this.lb_Customer_Phone.Size = new System.Drawing.Size(55, 33);
            this.lb_Customer_Phone.TabIndex = 20;
            this.lb_Customer_Phone.Text = "性别:";
            // 
            // tb_CustomerPhone
            // 
            // 
            // 
            // 
            this.tb_CustomerPhone.Border.Class = "TextBoxBorder";
            this.tb_CustomerPhone.Location = new System.Drawing.Point(510, 25);
            this.tb_CustomerPhone.Name = "tb_CustomerPhone";
            this.tb_CustomerPhone.Size = new System.Drawing.Size(177, 21);
            this.tb_CustomerPhone.TabIndex = 22;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(409, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 33);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "客户手机:";
            // 
            // tb_CustomerAddress
            // 
            // 
            // 
            // 
            this.tb_CustomerAddress.Border.Class = "TextBoxBorder";
            this.tb_CustomerAddress.Location = new System.Drawing.Point(510, 90);
            this.tb_CustomerAddress.Multiline = true;
            this.tb_CustomerAddress.Name = "tb_CustomerAddress";
            this.tb_CustomerAddress.Size = new System.Drawing.Size(177, 118);
            this.tb_CustomerAddress.TabIndex = 32;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(407, 90);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 33);
            this.labelX3.TabIndex = 31;
            this.labelX3.Text = "客户地址:";
            // 
            // cb_Agender
            // 
            this.cb_Agender.DisplayMember = "Text";
            this.cb_Agender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Agender.FormattingEnabled = true;
            this.cb_Agender.ItemHeight = 15;
            this.cb_Agender.Items.AddRange(new object[] {
            this.comboItemMen,
            this.comboItemWomen});
            this.cb_Agender.Location = new System.Drawing.Point(117, 81);
            this.cb_Agender.Name = "cb_Agender";
            this.cb_Agender.Size = new System.Drawing.Size(194, 21);
            this.cb_Agender.TabIndex = 33;
            // 
            // comboItemMen
            // 
            this.comboItemMen.Text = "男";
            // 
            // comboItemWomen
            // 
            this.comboItemWomen.Text = "女";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(23, 132);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 35;
            this.labelX2.Text = "电话类型:";
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
            this.comboBoxExPhoneType.Location = new System.Drawing.Point(117, 132);
            this.comboBoxExPhoneType.Name = "comboBoxExPhoneType";
            this.comboBoxExPhoneType.Size = new System.Drawing.Size(194, 21);
            this.comboBoxExPhoneType.TabIndex = 34;
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
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.comboBoxExPhoneType);
            this.Controls.Add(this.cb_Agender);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tb_CustomerAddress);
            this.Controls.Add(this.bt_Del);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.lb_Customer_Name);
            this.Controls.Add(this.tb_Customer_Name);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lb_Customer_Phone);
            this.Controls.Add(this.tb_CustomerPhone);
            this.Name = "AddCustomer";
            this.Size = new System.Drawing.Size(767, 364);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX bt_Del;
        private DevComponents.DotNetBar.ButtonX bt_Save;
        private DevComponents.DotNetBar.LabelX lb_Customer_Name;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Customer_Name;
        private DevComponents.DotNetBar.LabelX lb_Customer_Phone;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_CustomerPhone;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_CustomerAddress;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Agender;
        private DevComponents.Editors.ComboItem comboItemMen;
        private DevComponents.Editors.ComboItem comboItemWomen;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxExPhoneType;
        private DevComponents.Editors.ComboItem comboItemA;
        private DevComponents.Editors.ComboItem comboItemB;
        private DevComponents.Editors.ComboItem comboItemC;
    }
}
