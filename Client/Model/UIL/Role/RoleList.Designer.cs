namespace CustomerSeller.UIL.Role
{
    partial class RoleList
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_select = new DevComponents.DotNetBar.ButtonX();
            this.tb_role_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_roles = new System.Windows.Forms.DataGridView();
            this.cms_role = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_update = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).BeginInit();
            this.cms_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 201);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Controls.Add(this.tb_role_name);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选条件";
            // 
            // btn_select
            // 
            this.btn_select.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_select.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_select.Location = new System.Drawing.Point(248, 145);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "查询";
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // tb_role_name
            // 
            // 
            // 
            // 
            this.tb_role_name.Border.Class = "TextBoxBorder";
            this.tb_role_name.Location = new System.Drawing.Point(248, 84);
            this.tb_role_name.Name = "tb_role_name";
            this.tb_role_name.Size = new System.Drawing.Size(100, 21);
            this.tb_role_name.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(147, 84);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "角色名：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_roles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 401);
            this.panel2.TabIndex = 1;
            // 
            // dgv_roles
            // 
            this.dgv_roles.AllowUserToAddRows = false;
            this.dgv_roles.AllowUserToDeleteRows = false;
            this.dgv_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_roles.ContextMenuStrip = this.cms_role;
            this.dgv_roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_roles.Location = new System.Drawing.Point(0, 0);
            this.dgv_roles.Name = "dgv_roles";
            this.dgv_roles.RowTemplate.Height = 23;
            this.dgv_roles.Size = new System.Drawing.Size(825, 401);
            this.dgv_roles.TabIndex = 0;
            this.dgv_roles.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_roles_CellMouseDown);
            // 
            // cms_role
            // 
            this.cms_role.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_add,
            this.tsm_update,
            this.tsm_delete});
            this.cms_role.Name = "cms_user";
            this.cms_role.Size = new System.Drawing.Size(153, 92);
            this.cms_role.Text = "操作";
            // 
            // tsm_add
            // 
            this.tsm_add.Name = "tsm_add";
            this.tsm_add.Size = new System.Drawing.Size(152, 22);
            this.tsm_add.Text = "添加";
            this.tsm_add.Click += new System.EventHandler(this.tsm_add_Click);
            // 
            // tsm_update
            // 
            this.tsm_update.Name = "tsm_update";
            this.tsm_update.Size = new System.Drawing.Size(152, 22);
            this.tsm_update.Text = "修改";
            this.tsm_update.Click += new System.EventHandler(this.tsm_update_Click);
            // 
            // tsm_delete
            // 
            this.tsm_delete.Name = "tsm_delete";
            this.tsm_delete.Size = new System.Drawing.Size(152, 22);
            this.tsm_delete.Text = "删除";
            this.tsm_delete.Click += new System.EventHandler(this.tsm_delete_Click);
            // 
            // RoleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RoleList";
            this.Size = new System.Drawing.Size(825, 602);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).EndInit();
            this.cms_role.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_role_name;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_select;
        private System.Windows.Forms.DataGridView dgv_roles;
        private System.Windows.Forms.ContextMenuStrip cms_role;
        private System.Windows.Forms.ToolStripMenuItem tsm_add;
        private System.Windows.Forms.ToolStripMenuItem tsm_update;
        private System.Windows.Forms.ToolStripMenuItem tsm_delete;
    }
}
