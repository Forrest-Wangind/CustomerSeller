USE [CustomerSeller]
GO
/****** Object:  StoredProcedure [dbo].[SP_AllocateEmployeePhoneByAdmin]    Script Date: 2016/7/2 17:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_AllocateEmployeePhoneByAdmin] (@CustomerID uniqueidentifier ,@UserID nvarchar(20))
as
begin
	begin try
		begin tran t1
		declare @return as int;
		declare @error as int;
		declare @employeeIDOld as nvarchar(20);
		declare @PhoneType as nvarchar(20);

		set @error=0;
		/*初始化该电话的信息*/
		select @employeeIDOld=[EmployeeID],@PhoneType=PhoneType from  [dbo].[CustomerInfo] where [CustomerID]=@CustomerID and ( [EmployeeID]<>@UserID  or [EmployeeID] is null);
		update [CustomerInfo] with(rowlock) set [EmployeeID]=@UserID,AllocateTime=getdate() where [CustomerID]=@CustomerID;
		set @error=@@error+@error;
		/*修改被除掉一个电话的业务员*/
		if(exists(select 1 from AllocatePhoneDetailInfo where UserID=@employeeIDOld and [PhoneType]=@PhoneType ))
		update AllocatePhoneDetailInfo set [AllocateTime]=getdate(), [TotalCount]=(case  when [TotalCount]>0 then [TotalCount]-1 else 0 end) where UserID=@employeeIDOld and [PhoneType]=@PhoneType ;
		set @error=@@error+@error;
		if(@error=0)
		set @return=1;--分配成功
		if(@error=0)
		begin
			select @return;
			commit tran t1
		end
	end try

	begin catch
		set @return=-1;
		select @return;
		rollback tran t1
	end catch
end

