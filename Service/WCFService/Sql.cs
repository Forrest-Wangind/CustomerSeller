using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService
{
    public class Sql
    {
        public static string customerTotalNumber = "select count(1) from(SELECT 1 as column1 FROM CustomerInfo where 1=1 {0})A";
        public static string customerInfoDetail = @" SELECT TOP {0} [CustomerID],RowNumber 序号,rtrim(ltrim([CustomerName])) 客户姓名,[CustomerGender] 客户性别,CustomerPhone 客户的电话,[PhoneStratus] 电话的状态, 
                                             [AllocateTime] 获取时间,[DealTime] 成交时间,[PhoneType] 电话类型,remark [备注],分配的员工 FROM (
                                             SELECT ROW_NUMBER() OVER (ORDER BY CustomerID) AS RowNumber,[CustomerID],[CustomerName],[CustomerGender],STUFF([CustomerPhone],4,5,'*****') as CustomerPhone,[CustomerAddress],[PhoneStratus],[AllocateTime],[DealTime],[PhoneType],substring(remark,1,20) as remark,
											 (case  when EmployeeID is null or EmployeeID='' then '' else ( select UserName from [dbo].[UserInfo] where UserID=EmployeeID ) end  ) '分配的员工'
		                                     FROM CustomerInfo where 1=1 {2} ) A WHERE RowNumber > {0}*({1}-1) order by [AllocateTime] desc";
        public static string CustomerInfo = @"select CustomerGender,CustomerPhone,CustomerAddress ,Remark	,PhoneStratus,	DealTime	,CustomerName from [dbo].[CustomerInfo] 
                                              where CustomerID='{0}'";

        public static string AllocateEmployeePhone = "exec AllocateEmployeePhone '{0}','{1}'";
        public static string AllocateEmployeePhoneByAdmin = "exec SP_AllocateEmployeePhoneByAdmin '{0}','{1}'";

        public static string RecycleCustomerPhone ="exec RecycleCustomerPhone '{0}','{1}'";
        public static string JudgePhoneExists = @" if(exists(select 1 from [dbo].[CustomerInfo]with (nolock) where CustomerPhone='{0}'))
                                                select 1;
                                                else
                                                select -1 ";


    }
}