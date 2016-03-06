using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFService.Model;

namespace WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {

        // TODO: 在此添加您的服务操作
        [OperationContract]
        DataSet GetCustomer(int PageSize, int CurrentPage, List<KeyValuePair<string, string>> Parameters);

        [OperationContract]
        DataSet GetCustomerDetail(string CustomerID);

        [OperationContract]
        int UpdateCustomerInfo(string CustomerAddress = "", string Remark = "", string PhoneStratus = "", DateTime? DealTime = null, string CustomerID = "", string MobilePhone = "", string CustomerName = "");

        [OperationContract]
        Boolean BatchImportCustomerInfo(DataSet ds);

        [OperationContract]
        int AllocateEmployeePhone(string UserID);

        [OperationContract]
        int RecycleCustomerPhone(string customerID, string employeeID);

        [OperationContract]
        string[] GetUserPermissions(string userId);

        [OperationContract]
        DataSet GetUsers(User user);

        [OperationContract]
        User GetSingleUser(string userId);

        [OperationContract]
        int test(int a);
    }
}
