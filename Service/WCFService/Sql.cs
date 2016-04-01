using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService
{
    public class Sql
    {
        public static string customerTotalNumber = "select count(1) from(SELECT 1 as column1 FROM CustomerInfo where 1=1 {0})A";
        public static string customerInfoDetail = @"SELECT TOP {0} [CustomerID],RowNumber 序号,[CustomerName] 客户姓名,[CustomerGender] 客户性别,CustomerPhone 客户的电话,[PhoneStratus] 电话的状态, 
                                             [CreateTime] 创建时间,[DealTime] 成交时间,[PhoneType] 电话类型 FROM (
                                             SELECT ROW_NUMBER() OVER (ORDER BY CustomerID) AS RowNumber,[CustomerID],[CustomerName],[CustomerGender],STUFF([CustomerPhone],4,5,'*****') as CustomerPhone,[CustomerAddress],[PhoneStratus],[CreateTime],[DealTime],[PhoneType]
		                                     FROM CustomerInfo where 1=1 {2} ) A WHERE RowNumber > {0}*({1}-1)";
        public static string CustomerInfo = @"select CustomerGender,CustomerPhone,CustomerAddress ,Remark	,PhoneStratus,	DealTime	,CustomerName from [dbo].[CustomerInfo] 
                                              where CustomerID='{0}'";

        public static string AllocateEmployeePhone = "exec AllocateEmployeePhone {0},{1},'{2}','{3}'";

        public static string RecycleCustomerPhone ="exec RecycleCustomerPhone '{0}','{1}'";
        public static string JudgePhoneExists = @" if(exists(select 1 from [dbo].[CustomerInfo]with (nolock) where CustomerPhone='{0}'))
                                                select 1;
                                                else
                                                select -1 ";


    }
}