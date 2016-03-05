namespace Model.UIL
{
    partial class User_Update
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
            this.tb_Pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_Pwd = new DevComponents.DotNetBar.LabelX();
            this.tb_userId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_userId = new DevComponents.DotNetBar.LabelX();
            this.bt_Cancer = new DevComponents.DotNetBar.ButtonX();
            this.bt_Ok = new DevComponents.DotNetBar.ButtonX();
            this.tb_New_Pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_new_Pwd = new DevComponents.DotNetBar.LabelX();
            this.tb_Repeated_Pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_Repeated_Pwd = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // tb_Pwd
            // 
            // 
            // 
            // 
            this.tb_Pwd.Border.Class = "TextBoxBorder";
            this.tb_Pwd.Location = new System.Drawing.Point(164, 165);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.Size = new System.Drawing.Size(155, 21);
            this.tb_Pwd.TabIndex = 11;
            // 
            // lb_Pwd
            // 
            this.lb_Pwd.Location = new System.Drawing.Point(70, 165);
            this.lb_Pwd.Name = "lb_Pwd";
            this.lb_Pwd.Size = new System.Drawing.Size(75, 23);
            this.lb_Pwd.TabIndex = 10;
            this.lb_Pwd.Text = "原来密码：";
            // 
            // tb_userId
            // 
            // 
            // 
            // 
            this.tb_userId.Border.Class = "TextBoxBorder";
            this.tb_userId.Location = new System.Drawing.Point(164, 121);
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(155, 21);
            this.tb_userId.TabIndex = 9;
            // 
            // lb_userId
            // 
            this.lb_userId.Location = new System.Drawing.Point(70, 121);
            this.lb_userId.Name = "lb_userId";
            this.lb_userId.Size = new System.Drawing.Size(75, 23);
            this.lb_userId.TabIndex = 8;
            this.lb_userId.Text = "用户编号：";
            // 
            // bt_Cancer
            // 
            this.bt_Cancer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Cancer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Cancer.Location = new System.Drawing.Point(367, 265);
            this.bt_Cancer.Name = "bt_Cancer";
            this.bt_Cancer.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancer.TabIndex = 7;
            this.bt_Cancer.Text = "取消";
            this.bt_Cancer.Click += new System.EventHandler(this.bt_Cancer_Click);
            // 
            // bt_Ok
            // 
            this.bt_Ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Ok.Location = new System.Drawing.Point(193, 265);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.bt_Ok.TabIndex = 6;
            this.bt_Ok.Text = "确定";
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // tb_New_Pwd
            // 
            // 
            // 
            // 
            this.tb_New_Pwd.Border.Class = "TextBoxBorder";
            this.tb_New_Pwd.Location = new System.Drawing.Point(500, 117);
            this.tb_New_Pwd.Name = "tb_New_Pwd";
            this.tb_New_Pwd.Size = new System.Drawing.Size(155, 21);
            this.tb_New_Pwd.TabIndex = 13;
            // 
            // lb_new_Pwd
            // 
            this.lb_new_Pwd.Location = new System.Drawing.Point(406, 117);
            this.lb_new_Pwd.Name = "lb_new_Pwd";
            this.lb_new_Pwd.Size = new System.Drawing.Size(75, 23);
            this.lb_new_Pwd.TabIndex = 12;
            this.lb_new_Pwd.Text = "新的密码：";
            // 
            // tb_Repeated_Pwd
            // 
            // 
            // 
            // 
            this.tb_Repeated_Pwd.Border.Class = "TextBoxBorder";
            this.tb_Repeated_Pwd.Location = new System.Drawing.Point(500, 162);
            this.tb_Repeated_Pwd.Name = "tb_Repeated_Pwd";
            this.tb_Repeated_Pwd.Size = new System.Drawing.Size(155, 21);
            this.tb_Repeated_Pwd.TabIndex = 15;
            // 
            // lb_Repeated_Pwd
            // 
            this.lb_Repeated_Pwd.Location = new System.Drawing.Point(406, 162);
            this.lb_Repeated_Pwd.Name = "lb_Repeated_Pwd";
            this.lb_Repeated_Pwd.Size = new System.Drawing.Size(75, 23);
            this.lb_Repeated_Pwd.TabIndex = 14;
            this.lb_Repeated_Pwd.Text = "复核密码：";
            // 
            // User_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tb_Repeated_Pwd);
            this.Controls.Add(this.lb_Repeated_Pwd);
            this.Controls.Add(this.tb_New_Pwd);
            this.Controls.Add(this.lb_new_Pwd);
            this.Controls.Add(this.tb_Pwd);
            this.Controls.Add(this.lb_Pwd);
            this.Controls.Add(this.tb_userId);
            this.Controls.Add(this.lb_userId);
            this.Controls.Add(this.bt_Cancer);
            this.Controls.Add(this.bt_Ok);
            this.Name = "User_Update";
            this.Size = new System.Drawing.Size(675, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tb_Pwd;
        private DevComponents.DotNetBar.LabelX lb_Pwd;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_userId;
        private DevComponents.DotNetBar.LabelX lb_userId;
        private DevComponents.DotNetBar.ButtonX bt_Cancer;
        private DevComponents.DotNetBar.ButtonX bt_Ok;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_New_Pwd;
        private DevComponents.DotNetBar.LabelX lb_new_Pwd;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Repeated_Pwd;
        private DevComponents.DotNetBar.LabelX lb_Repeated_Pwd;
    }
}
