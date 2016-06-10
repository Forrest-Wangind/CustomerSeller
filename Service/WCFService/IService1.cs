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
        int AllocateEmployeePhone(string UserID, string phoneType);

        [OperationContract]
        int RecycleCustomerPhone(string customerID, string employeeID);

        [OperationContract]
        string[] GetUserPermissions(string userId);

        [OperationContract]
        DataSet GetRoleFunctions(string roleId);

        [OperationContract]
        DataSet GetUserRoles(string userId);

        [OperationContract]
        DataSet GetRoles(Role role);

        [OperationContract]
        DataSet GetSaleLevels(SaleLevel saleLevel);

        [OperationContract]
        DataSet GetSaleGroups(SaleGroup saleGroup);

        [OperationContract]
        SaleLevel GetSaleLevelDetail(string levelId);

        [OperationContract]
        SaleGroup GetSaleGroupDetail(string groupId);

        [OperationContract]
        DataSet GetPermissions(string userId);

        [OperationContract]
        DataSet GetUsers(User user);

        [OperationContract]
        User GetSingleUser(string userId);

        [OperationContract]
        bool AddUser(User user);

        [OperationContract]
        bool AddRole(Role role);

        [OperationContract]
        bool AddSaleLevel(SaleLevel level);

        [OperationContract]
        bool AddSaleGroup(SaleGroup group);

        [OperationContract]
        bool UpdateUser(User user);

        [OperationContract]
        bool UpdateRole(Role role);

        [OperationContract]
        bool UpdateSaleLevel(SaleLevel level);

        [OperationContract]
        bool UpdateSaleGroup(SaleGroup group);

        [OperationContract]
        bool DeleteUser(string userId);

        [OperationContract]
        bool DeleteRole(string roleId);

        [OperationContract]
        bool DeleteSaleLevel(string levelId);

        [OperationContract]
        bool DeleteSaleGroup(string groupId);

        [OperationContract]
        Role GetRoleDetail(string roleId);

        [OperationContract]
        int test(int a);

        [OperationContract]
        Boolean CallMobilePhone(string phone, string employeeID, string employeeExten);

        [OperationContract]
        Boolean SetPhoneParams(string dailyNumber, string totalNumber, string phoneType);

        [OperationContract]
        DataSet GetUserInfo(User user);

        [OperationContract]
        bool ChangeUserPwd(User user);

        [OperationContract]
        bool LogoutUser(string userId);

        [OperationContract]
        bool LogoutAllUsers();

        [OperationContract]
        DataSet GetPhoneDetail(string phoneType, User user);
        
        [OperationContract]
        int AllocateEmployeePhoneByAdmin(string customerID, string userID);
    }
}
