namespace CustomerSeller.UIL.Customer
{
    partial class CustomerUserControl
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
            this.components = new System.ComponentModel.Container();
            this.tabControl_Customer = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel_Customer = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Customer)).BeginInit();
            this.tabControl_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Customer
            // 
            this.tabControl_Customer.CanReorderTabs = true;
            this.tabControl_Customer.Controls.Add(this.tabControlPanel_Customer);
            this.tabControl_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Customer.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Customer.Name = "tabControl_Customer";
            this.tabControl_Customer.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl_Customer.SelectedTabIndex = 0;
            this.tabControl_Customer.Size = new System.Drawing.Size(677, 481);
            this.tabControl_Customer.TabIndex = 0;
            this.tabControl_Customer.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl_Customer.Tabs.Add(this.tabItem1);
            this.tabControl_Customer.Text = "tabControl";
            // 
            // tabControlPanel_Customer
            // 
            this.tabControlPanel_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_Customer.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel_Customer.Name = "tabControlPanel_Customer";
            this.tabControlPanel_Customer.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_Customer.Size = new System.Drawing.Size(677, 455);
            this.tabControlPanel_Customer.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel_Customer.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel_Customer.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_Customer.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel_Customer.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_Customer.Style.GradientAngle = 90;
            this.tabControlPanel_Customer.TabIndex = 1;
            this.tabControlPanel_Customer.TabItem = this.tabItem1;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel_Customer;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "tabItem1";
            // 
            // CustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_Customer);
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(677, 481);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Customer)).EndInit();
            this.tabControl_Customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.TabControl tabControl_Customer;
        internal DevComponents.DotNetBar.TabControlPanel tabControlPanel_Customer;
        internal DevComponents.DotNetBar.TabItem tabItem_Customer;
        internal DevComponents.DotNetBar.TabItem tabItem1;


    }
}
