namespace Model
{
    partial class Control_Inquire_Vip
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
            this.base_Msg = new System.Windows.Forms.GroupBox();
            this.bt_inport = new DevComponents.DotNetBar.ButtonX();
            this.pb_fruit = new System.Windows.Forms.PictureBox();
            this.lb_vip_Credits = new DevComponents.DotNetBar.LabelX();
            this.tb_Fruit_Remark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_Fruit_InPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_fruit_OutPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_Fruit_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_vip_Tel = new DevComponents.DotNetBar.LabelX();
            this.lb_vip_IdentityCard = new DevComponents.DotNetBar.LabelX();
            this.lb_vip_name = new DevComponents.DotNetBar.LabelX();
            this.lb_vip_Id = new DevComponents.DotNetBar.LabelX();
            this.Inquire_Msg = new System.Windows.Forms.GroupBox();
            this.bt_delete = new DevComponents.DotNetBar.ButtonX();
            this.bt_Update = new DevComponents.DotNetBar.ButtonX();
            this.cb_Condition = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_Fruit_Name = new DevComponents.Editors.ComboItem();
            this.bt_Inquire = new DevComponents.DotNetBar.ButtonX();
            this.tb_Inquire = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.base_Msg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fruit)).BeginInit();
            this.Inquire_Msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // base_Msg
            // 
            this.base_Msg.Controls.Add(this.bt_inport);
            this.base_Msg.Controls.Add(this.pb_fruit);
            this.base_Msg.Controls.Add(this.lb_vip_Credits);
            this.base_Msg.Controls.Add(this.tb_Fruit_Remark);
            this.base_Msg.Controls.Add(this.tb_Fruit_InPrice);
            this.base_Msg.Controls.Add(this.tb_fruit_OutPrice);
            this.base_Msg.Controls.Add(this.tb_Fruit_Name);
            this.base_Msg.Controls.Add(this.lb_vip_Tel);
            this.base_Msg.Controls.Add(this.lb_vip_IdentityCard);
            this.base_Msg.Controls.Add(this.lb_vip_name);
            this.base_Msg.Controls.Add(this.lb_vip_Id);
            this.base_Msg.Location = new System.Drawing.Point(21, 159);
            this.base_Msg.Name = "base_Msg";
            this.base_Msg.Size = new System.Drawing.Size(642, 251);
            this.base_Msg.TabIndex = 30;
            this.base_Msg.TabStop = false;
            this.base_Msg.Text = "水果信息";
            // 
            // bt_inport
            // 
            this.bt_inport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_inport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_inport.Location = new System.Drawing.Point(22, 170);
            this.bt_inport.Name = "bt_inport";
            this.bt_inport.Size = new System.Drawing.Size(37, 23);
            this.bt_inport.TabIndex = 38;
            this.bt_inport.Text = "导入";
            this.bt_inport.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // pb_fruit
            // 
            this.pb_fruit.Location = new System.Drawing.Point(127, 131);
            this.pb_fruit.Name = "pb_fruit";
            this.pb_fruit.Size = new System.Drawing.Size(186, 114);
            this.pb_fruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fruit.TabIndex = 37;
            this.pb_fruit.TabStop = false;
            // 
            // lb_vip_Credits
            // 
            this.lb_vip_Credits.Location = new System.Drawing.Point(22, 131);
            this.lb_vip_Credits.Name = "lb_vip_Credits";
            this.lb_vip_Credits.Size = new System.Drawing.Size(53, 33);
            this.lb_vip_Credits.TabIndex = 36;
            this.lb_vip_Credits.Text = "图片：";
            // 
            // tb_Fruit_Remark
            // 
            // 
            // 
            // 
            this.tb_Fruit_Remark.Border.Class = "TextBoxBorder";
            this.tb_Fruit_Remark.Location = new System.Drawing.Point(439, 83);
            this.tb_Fruit_Remark.Multiline = true;
            this.tb_Fruit_Remark.Name = "tb_Fruit_Remark";
            this.tb_Fruit_Remark.Size = new System.Drawing.Size(186, 75);
            this.tb_Fruit_Remark.TabIndex = 35;
            // 
            // tb_Fruit_InPrice
            // 
            // 
            // 
            // 
            this.tb_Fruit_InPrice.Border.Class = "TextBoxBorder";
            this.tb_Fruit_InPrice.Location = new System.Drawing.Point(439, 41);
            this.tb_Fruit_InPrice.Name = "tb_Fruit_InPrice";
            this.tb_Fruit_InPrice.Size = new System.Drawing.Size(186, 21);
            this.tb_Fruit_InPrice.TabIndex = 34;
            // 
            // tb_fruit_OutPrice
            // 
            // 
            // 
            // 
            this.tb_fruit_OutPrice.Border.Class = "TextBoxBorder";
            this.tb_fruit_OutPrice.Location = new System.Drawing.Point(127, 86);
            this.tb_fruit_OutPrice.Name = "tb_fruit_OutPrice";
            this.tb_fruit_OutPrice.Size = new System.Drawing.Size(186, 21);
            this.tb_fruit_OutPrice.TabIndex = 33;
            // 
            // tb_Fruit_Name
            // 
            // 
            // 
            // 
            this.tb_Fruit_Name.Border.Class = "TextBoxBorder";
            this.tb_Fruit_Name.Location = new System.Drawing.Point(127, 42);
            this.tb_Fruit_Name.Name = "tb_Fruit_Name";
            this.tb_Fruit_Name.Size = new System.Drawing.Size(186, 21);
            this.tb_Fruit_Name.TabIndex = 32;
            // 
            // lb_vip_Tel
            // 
            this.lb_vip_Tel.Location = new System.Drawing.Point(334, 83);
            this.lb_vip_Tel.Name = "lb_vip_Tel";
            this.lb_vip_Tel.Size = new System.Drawing.Size(139, 33);
            this.lb_vip_Tel.TabIndex = 31;
            this.lb_vip_Tel.Text = "备注：";
            // 
            // lb_vip_IdentityCard
            // 
            this.lb_vip_IdentityCard.Location = new System.Drawing.Point(334, 39);
            this.lb_vip_IdentityCard.Name = "lb_vip_IdentityCard";
            this.lb_vip_IdentityCard.Size = new System.Drawing.Size(139, 33);
            this.lb_vip_IdentityCard.TabIndex = 30;
            this.lb_vip_IdentityCard.Text = "进价:";
            // 
            // lb_vip_name
            // 
            this.lb_vip_name.Location = new System.Drawing.Point(22, 79);
            this.lb_vip_name.Name = "lb_vip_name";
            this.lb_vip_name.Size = new System.Drawing.Size(139, 33);
            this.lb_vip_name.TabIndex = 29;
            this.lb_vip_name.Text = "售价：";
            // 
            // lb_vip_Id
            // 
            this.lb_vip_Id.Location = new System.Drawing.Point(22, 33);
            this.lb_vip_Id.Name = "lb_vip_Id";
            this.lb_vip_Id.Size = new System.Drawing.Size(139, 33);
            this.lb_vip_Id.TabIndex = 28;
            this.lb_vip_Id.Text = "水果名称:";
            // 
            // Inquire_Msg
            // 
            this.Inquire_Msg.Controls.Add(this.bt_delete);
            this.Inquire_Msg.Controls.Add(this.bt_Update);
            this.Inquire_Msg.Controls.Add(this.cb_Condition);
            this.Inquire_Msg.Controls.Add(this.bt_Inquire);
            this.Inquire_Msg.Controls.Add(this.tb_Inquire);
            this.Inquire_Msg.Location = new System.Drawing.Point(21, 34);
            this.Inquire_Msg.Name = "Inquire_Msg";
            this.Inquire_Msg.Size = new System.Drawing.Size(642, 107);
            this.Inquire_Msg.TabIndex = 31;
            this.Inquire_Msg.TabStop = false;
            this.Inquire_Msg.Text = "查询条件";
            // 
            // bt_delete
            // 
            this.bt_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_delete.Location = new System.Drawing.Point(282, 78);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 39;
            this.bt_delete.Text = "删除";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Update.Location = new System.Drawing.Point(171, 76);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 38;
            this.bt_Update.Text = "修改";
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // cb_Condition
            // 
            this.cb_Condition.DisplayMember = "Text";
            this.cb_Condition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Condition.FormattingEnabled = true;
            this.cb_Condition.ItemHeight = 15;
            this.cb_Condition.Items.AddRange(new object[] {
            this.cb_Fruit_Name});
            this.cb_Condition.Location = new System.Drawing.Point(22, 21);
            this.cb_Condition.Name = "cb_Condition";
            this.cb_Condition.Size = new System.Drawing.Size(127, 21);
            this.cb_Condition.TabIndex = 37;
            // 
            // cb_Fruit_Name
            // 
            this.cb_Fruit_Name.Text = "水果名称";
            // 
            // bt_Inquire
            // 
            this.bt_Inquire.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Inquire.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Inquire.Location = new System.Drawing.Point(22, 76);
            this.bt_Inquire.Name = "bt_Inquire";
            this.bt_Inquire.Size = new System.Drawing.Size(75, 23);
            this.bt_Inquire.TabIndex = 35;
            this.bt_Inquire.Text = "查询";
            //this.bt_Inquire.Click += new System.EventHandler(this.bt_Inquire_Click);
            // 
            // tb_Inquire
            // 
            // 
            // 
            // 
            this.tb_Inquire.Border.Class = "TextBoxBorder";
            this.tb_Inquire.Location = new System.Drawing.Point(171, 21);
            this.tb_Inquire.Name = "tb_Inquire";
            this.tb_Inquire.Size = new System.Drawing.Size(186, 21);
            this.tb_Inquire.TabIndex = 34;
            // 
            // Control_Inquire_Vip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Inquire_Msg);
            this.Controls.Add(this.base_Msg);
            this.Name = "Control_Inquire_Vip";
            this.Size = new System.Drawing.Size(675, 468);
            this.base_Msg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_fruit)).EndInit();
            this.Inquire_Msg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox base_Msg;
        private DevComponents.DotNetBar.LabelX lb_vip_Credits;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Fruit_Remark;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Fruit_InPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_fruit_OutPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Fruit_Name;
        private DevComponents.DotNetBar.LabelX lb_vip_Tel;
        private DevComponents.DotNetBar.LabelX lb_vip_IdentityCard;
        private DevComponents.DotNetBar.LabelX lb_vip_name;
        private DevComponents.DotNetBar.LabelX lb_vip_Id;
        private System.Windows.Forms.GroupBox Inquire_Msg;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Inquire;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Condition;
        private DevComponents.DotNetBar.ButtonX bt_Inquire;
        private DevComponents.Editors.ComboItem cb_Fruit_Name;
        private DevComponents.DotNetBar.ButtonX bt_Update;
        private DevComponents.DotNetBar.ButtonX bt_delete;
        private System.Windows.Forms.PictureBox pb_fruit;
        private DevComponents.DotNetBar.ButtonX bt_inport;


    }
}
