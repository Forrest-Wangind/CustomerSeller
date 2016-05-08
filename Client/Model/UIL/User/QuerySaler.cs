using CustomerSeller.Common;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSeller.UIL.User
{
    public partial class QuerySaler : Office2007Form
    {
        public List<Saler> SalerLists = new List<Saler>();
        public EmployeePhoneInfo.Employee employeeInfo ;
        public QuerySaler()
        {
            InitializeComponent();
        }

        public QuerySaler(EmployeePhoneInfo.Employee EmployeeInfo)
        {
            InitializeComponent();
            employeeInfo = EmployeeInfo;
            this.dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ReadOnly = true;
            LoadSaleInfo();
        }   
       
        /*初始化列表*/
        public void LoadSaleInfo()
        {   
            try
            {
                var ds = CustomerInfo.GetServiceInstance().GetUsers(new ServiceReference1.User() { entryTimeStart = DateTime.Parse("1900-01-01"), entryTimeEnd = DateTime.Parse("2999-12-31"), role = "salesman" });
                if (ds!=null&&ds.Tables[0].Rows.Count>0)
                {
                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        if (dr["角色名称"]!=DBNull.Value)
                        {
                            SalerLists.Add(new Saler() { Name = Convert.ToString(dr["姓名"] == DBNull.Value ? "" : dr["姓名"]),
                            UserID = Convert.ToString(dr["用户编号"] == DBNull.Value ? "" : dr["用户编号"]) });
                        }
                    }
                    
                    this.dgView.DataSource = SalerLists;
                   
                    
                }
            }
            catch
            {
                throw new Exception();
            }

           

           
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {  
            try
            {
                employeeInfo.EmployeeID = Convert.ToString(this.dgView.SelectedCells[0].Value.ToString());
                employeeInfo.EmployeeName = Convert.ToString(this.dgView.SelectedCells[1].Value.ToString());
              
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show("请选择业务员！", "提示");
                return;
            }
        
        }

        private void pbQuery_Click(object sender, EventArgs e)
        {
            this.dgView.DataSource = SalerLists.Where(item =>  item.Name == this.tb_EmployeeName.Text || item.UserID == this.tb_EmployeeName.Text).ToList();
        }
    }
    public class Saler
    {
        public string UserID { get; set; }
        public string Name { get; set; }

    }
}
