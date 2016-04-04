namespace LogoutUserApp
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_useId = new DevComponents.DotNetBar.LabelX();
            this.tb_userId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_logout_single_user = new DevComponents.DotNetBar.ButtonX();
            this.btn_all_users_logout = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lbl_useId
            // 
            this.lbl_useId.Location = new System.Drawing.Point(166, 146);
            this.lbl_useId.Name = "lbl_useId";
            this.lbl_useId.Size = new System.Drawing.Size(75, 23);
            this.lbl_useId.TabIndex = 1;
            this.lbl_useId.Text = "员工编号：";
            // 
            // tb_userId
            // 
            // 
            // 
            // 
            this.tb_userId.Border.Class = "TextBoxBorder";
            this.tb_userId.Location = new System.Drawing.Point(247, 146);
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(171, 21);
            this.tb_userId.TabIndex = 2;
            // 
            // btn_logout_single_user
            // 
            this.btn_logout_single_user.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_logout_single_user.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_logout_single_user.Location = new System.Drawing.Point(247, 193);
            this.btn_logout_single_user.Name = "btn_logout_single_user";
            this.btn_logout_single_user.Size = new System.Drawing.Size(97, 28);
            this.btn_logout_single_user.TabIndex = 3;
            this.btn_logout_single_user.Text = "单用户退出";
            this.btn_logout_single_user.Click += new System.EventHandler(this.btn_logout_single_user_Click);
            // 
            // btn_all_users_logout
            // 
            this.btn_all_users_logout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_all_users_logout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_all_users_logout.Location = new System.Drawing.Point(247, 261);
            this.btn_all_users_logout.Name = "btn_all_users_logout";
            this.btn_all_users_logout.Size = new System.Drawing.Size(97, 28);
            this.btn_all_users_logout.TabIndex = 4;
            this.btn_all_users_logout.Text = "所有用户退出";
            this.btn_all_users_logout.Click += new System.EventHandler(this.btn_all_users_logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 437);
            this.Controls.Add(this.btn_all_users_logout);
            this.Controls.Add(this.btn_logout_single_user);
            this.Controls.Add(this.tb_userId);
            this.Controls.Add(this.lbl_useId);
            this.Name = "Form1";
            this.Text = "员工退出系统";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_useId;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_userId;
        private DevComponents.DotNetBar.ButtonX btn_logout_single_user;
        private DevComponents.DotNetBar.ButtonX btn_all_users_logout;
    }
}

