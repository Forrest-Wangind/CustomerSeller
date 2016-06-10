namespace CustomerSeller.UIL.SaleGroup
{
    partial class GroupList
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
            this.components = new System.ComponentModel.Container();
            this.dgv_groups = new System.Windows.Forms.DataGridView();
            this.cms_group = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_update = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_select = new DevComponents.DotNetBar.ButtonX();
            this.tb_sale_group = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groups)).BeginInit();
            this.cms_group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_groups
            // 
            this.dgv_groups.AllowUserToAddRows = false;
            this.dgv_groups.AllowUserToDeleteRows = false;
            this.dgv_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_groups.ContextMenuStrip = this.cms_group;
            this.dgv_groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_groups.Location = new System.Drawing.Point(0, 0);
            this.dgv_groups.Name = "dgv_groups";
            this.dgv_groups.RowTemplate.Height = 23;
            this.dgv_groups.Size = new System.Drawing.Size(1005, 514);
            this.dgv_groups.TabIndex = 0;
            this.dgv_groups.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_groups_CellMouseDown);
            // 
            // cms_group
            // 
            this.cms_group.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_add,
            this.tsm_update,
            this.tsm_delete});
            this.cms_group.Name = "cms_user";
            this.cms_group.Size = new System.Drawing.Size(101, 70);
            this.cms_group.Text = "操作";
            // 
            // tsm_add
            // 
            this.tsm_add.Name = "tsm_add";
            this.tsm_add.Size = new System.Drawing.Size(100, 22);
            this.tsm_add.Text = "添加";
            this.tsm_add.Click += new System.EventHandler(this.tsm_add_Click);
            // 
            // tsm_update
            // 
            this.tsm_update.Name = "tsm_update";
            this.tsm_update.Size = new System.Drawing.Size(100, 22);
            this.tsm_update.Text = "修改";
            this.tsm_update.Click += new System.EventHandler(this.tsm_update_Click);
            // 
            // tsm_delete
            // 
            this.tsm_delete.Name = "tsm_delete";
            this.tsm_delete.Size = new System.Drawing.Size(100, 22);
            this.tsm_delete.Text = "删除";
            this.tsm_delete.Click += new System.EventHandler(this.tsm_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Controls.Add(this.tb_sale_group);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选条件";
            // 
            // btn_select
            // 
            this.btn_select.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_select.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_select.Location = new System.Drawing.Point(446, 96);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "查询";
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // tb_sale_group
            // 
            // 
            // 
            // 
            this.tb_sale_group.Border.Class = "TextBoxBorder";
            this.tb_sale_group.Location = new System.Drawing.Point(446, 35);
            this.tb_sale_group.Name = "tb_sale_group";
            this.tb_sale_group.Size = new System.Drawing.Size(100, 21);
            this.tb_sale_group.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(345, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = " 销售部门：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_groups);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 514);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 164);
            this.panel1.TabIndex = 4;
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GroupList";
            this.Size = new System.Drawing.Size(1005, 678);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groups)).EndInit();
            this.cms_group.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_groups;
        private System.Windows.Forms.ContextMenuStrip cms_group;
        private System.Windows.Forms.ToolStripMenuItem tsm_add;
        private System.Windows.Forms.ToolStripMenuItem tsm_update;
        private System.Windows.Forms.ToolStripMenuItem tsm_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_select;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_sale_group;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}