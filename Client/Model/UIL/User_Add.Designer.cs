namespace Model.UIL
{
    partial class User_Add
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
            this.bt_Ok = new DevComponents.DotNetBar.ButtonX();
            this.bt_Cancer = new DevComponents.DotNetBar.ButtonX();
            this.lb_userId = new DevComponents.DotNetBar.LabelX();
            this.tb_userId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_Pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_Pwd = new DevComponents.DotNetBar.LabelX();
            this.bt_Del = new DevComponents.DotNetBar.ButtonX();
            this.cb_grade = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bt_Ok
            // 
            this.bt_Ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Ok.Location = new System.Drawing.Point(174, 273);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.bt_Ok.TabIndex = 0;
            this.bt_Ok.Text = "确定";
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_Cancer
            // 
            this.bt_Cancer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Cancer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Cancer.Location = new System.Drawing.Point(301, 273);
            this.bt_Cancer.Name = "bt_Cancer";
            this.bt_Cancer.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancer.TabIndex = 1;
            this.bt_Cancer.Text = "取消";
            this.bt_Cancer.Click += new System.EventHandler(this.bt_Cancer_Click);
            // 
            // lb_userId
            // 
            this.lb_userId.Location = new System.Drawing.Point(174, 114);
            this.lb_userId.Name = "lb_userId";
            this.lb_userId.Size = new System.Drawing.Size(75, 23);
            this.lb_userId.TabIndex = 2;
            this.lb_userId.Text = "用户编号：";
            // 
            // tb_userId
            // 
            // 
            // 
            // 
            this.tb_userId.Border.Class = "TextBoxBorder";
            this.tb_userId.Location = new System.Drawing.Point(268, 114);
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(155, 21);
            this.tb_userId.TabIndex = 3;
            this.tb_userId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_userId_KeyDown);
            // 
            // tb_Pwd
            // 
            // 
            // 
            // 
            this.tb_Pwd.Border.Class = "TextBoxBorder";
            this.tb_Pwd.Location = new System.Drawing.Point(268, 166);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.Size = new System.Drawing.Size(155, 21);
            this.tb_Pwd.TabIndex = 5;
            // 
            // lb_Pwd
            // 
            this.lb_Pwd.Location = new System.Drawing.Point(174, 166);
            this.lb_Pwd.Name = "lb_Pwd";
            this.lb_Pwd.Size = new System.Drawing.Size(75, 23);
            this.lb_Pwd.TabIndex = 4;
            this.lb_Pwd.Text = "用户密码：";
            // 
            // bt_Del
            // 
            this.bt_Del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Del.Location = new System.Drawing.Point(431, 273);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(75, 23);
            this.bt_Del.TabIndex = 6;
            this.bt_Del.Text = "删除";
            this.bt_Del.Click += new System.EventHandler(this.bt_Del_Click);
            // 
            // cb_grade
            // 
            this.cb_grade.AutoSize = true;
            this.cb_grade.Location = new System.Drawing.Point(481, 114);
            this.cb_grade.Name = "cb_grade";
            this.cb_grade.Size = new System.Drawing.Size(60, 16);
            this.cb_grade.TabIndex = 7;
            this.cb_grade.Text = "管理员";
            this.cb_grade.UseVisualStyleBackColor = true;
            // 
            // User_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cb_grade);
            this.Controls.Add(this.bt_Del);
            this.Controls.Add(this.tb_Pwd);
            this.Controls.Add(this.lb_Pwd);
            this.Controls.Add(this.tb_userId);
            this.Controls.Add(this.lb_userId);
            this.Controls.Add(this.bt_Cancer);
            this.Controls.Add(this.bt_Ok);
            this.Name = "User_Add";
            this.Size = new System.Drawing.Size(675, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX bt_Ok;
        private DevComponents.DotNetBar.ButtonX bt_Cancer;
        private DevComponents.DotNetBar.LabelX lb_userId;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_userId;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Pwd;
        private DevComponents.DotNetBar.LabelX lb_Pwd;
        private DevComponents.DotNetBar.ButtonX bt_Del;
        private System.Windows.Forms.CheckBox cb_grade;
    }
}
