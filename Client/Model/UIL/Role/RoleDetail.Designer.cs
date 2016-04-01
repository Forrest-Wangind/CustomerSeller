namespace CustomerSeller.UIL.Role
{
    partial class RoleDetail
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_user_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tb_role_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tb_remark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tree_functions = new System.Windows.Forms.TreeView();
            this.btn_submit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_user_name
            // 
            // 
            // 
            // 
            this.tb_user_name.Border.Class = "TextBoxBorder";
            this.tb_user_name.Location = new System.Drawing.Point(196, 217);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(100, 21);
            this.tb_user_name.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(115, 216);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "名称：";
            // 
            // tb_role_id
            // 
            // 
            // 
            // 
            this.tb_role_id.Border.Class = "TextBoxBorder";
            this.tb_role_id.Enabled = false;
            this.tb_role_id.Location = new System.Drawing.Point(196, 166);
            this.tb_role_id.Name = "tb_role_id";
            this.tb_role_id.Size = new System.Drawing.Size(100, 21);
            this.tb_role_id.TabIndex = 5;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(115, 165);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "角色编号：";
            // 
            // tb_remark
            // 
            // 
            // 
            // 
            this.tb_remark.Border.Class = "TextBoxBorder";
            this.tb_remark.Location = new System.Drawing.Point(196, 271);
            this.tb_remark.Name = "tb_remark";
            this.tb_remark.Size = new System.Drawing.Size(100, 21);
            this.tb_remark.TabIndex = 9;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(115, 271);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "备注：";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.tree_functions);
            this.groupPanel1.Location = new System.Drawing.Point(390, 108);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(371, 436);
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
            this.groupPanel1.TabIndex = 10;
            this.groupPanel1.Text = "权限";
            // 
            // tree_functions
            // 
            this.tree_functions.CheckBoxes = true;
            this.tree_functions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_functions.Location = new System.Drawing.Point(0, 0);
            this.tree_functions.Name = "tree_functions";
            this.tree_functions.Size = new System.Drawing.Size(365, 412);
            this.tree_functions.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_submit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_submit.Location = new System.Drawing.Point(196, 326);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 11;
            this.btn_submit.Text = "提交";
            this.btn_submit.Visible = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // RoleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.tb_remark);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tb_user_name);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tb_role_id);
            this.Controls.Add(this.labelX1);
            this.Name = "RoleDetail";
            this.Size = new System.Drawing.Size(904, 668);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tb_user_name;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_role_id;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_remark;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_submit;
        private System.Windows.Forms.TreeView tree_functions;
    }
}
