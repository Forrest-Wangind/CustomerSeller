USE [CustomerSeller]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteAllocatePhone]    Script Date: 2016/6/19 16:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[SP_DeleteAllocatePhone] (@customerId uniqueidentifier)
as
  begin
       begin tran t1
	   declare @count as int;
       declare @employeeID nvarchar(20),@phoneType varchar(10);
	   select @employeeID=EmployeeID,@phoneType=PhoneType from [dbo].[CustomerInfo] where [CustomerID]=@customerId;
	   insert into DeletedCustomerInfo select *,getdate() from [CustomerInfo] where  [CustomerID]=@customerId;
	   delete from [CustomerInfo] where  [CustomerID]=@customerId;
	   set @count=@@error;
	   update [dbo].[AllocatePhoneDetailInfo] set [TotalCount]=[TotalCount]-1 where [UserID]=@employeeID and [PhoneType]=@phoneType;
	   set @count=@@error+@count;
	   if(@count=0)
	   begin
		   commit  tran t1
		   select 1;
	   end
	   else
	   begin
	       rollback tran t1
		   select -1;
	   end
  end