USE [CustomerSeller]
GO
/****** Object:  StoredProcedure [dbo].[SP_AllocateEmployeePhoneByAdmin]    Script Date: 2016/5/8 11:35:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_AllocateEmployeePhoneByAdmin] (@CustomerID uniqueidentifier ,@UserID nvarchar(20))
as
   begin
   begin try
        	begin tran t1
			declare @allocateTime as datetime;
			declare @allocateCount as int;
			declare @totalCount as int;
			declare @return as int;
			declare @error as int;
			declare @influence as int;
			declare @MaxCount as int;
			declare @DailyMaxCount as int;
			declare @employeeIDOld as nvarchar(20);
			declare @PhoneType as nvarchar(20);

			/*初始化该电话的信息*/
		    select @employeeIDOld=[EmployeeID],@PhoneType=PhoneType from  [dbo].[CustomerInfo] where [CustomerID]=@CustomerID and ( [EmployeeID]<>@UserID  or [EmployeeID] is null);
			/*获取这个员工级别对应的电话的数量*/
			select @MaxCount=MaxNumber,@DailyMaxCount=DailyNumber from PhoneAllocateRule P inner join [dbo].[UserInfo] U on P.LevelID=U.LevelID where U.UserID=@UserID And P.PhoneType=@PhoneType;
			if((case when (@MaxCount>0 and @DailyMaxCount>0) then 1 else 0 end)=0)
			   begin
			   raiserror ('销售人员的级别为空',19,2);
			   end		
			if(not exists(select 1 from [dbo].[AllocatePhoneDetailInfo] where [UserID]=@UserID and [PhoneType]=@PhoneType))
			   begin
					insert into [dbo].[AllocatePhoneDetailInfo] select newid(),@PhoneType,0,0,@UserID,getdate();
					select @allocateCount=0,@totalCount=0;
			   end
			   else
			   begin
				   select  @allocateCount=isnull([DailyCount],0),@allocateTime=[AllocateTime],@totalCount=isnull([TotalCount],0) from [dbo].[AllocatePhoneDetailInfo] where UserID=@UserID and [PhoneType]=@PhoneType;
				   if(@allocateTime is null or CONVERT(varchar(100), @allocateTime, 23)<CONVERT(varchar(100), GETDATE(), 23))
					  set @allocateCount=0;
			   end
			if(@allocateCount<@DailyMaxCount and @totalCount<@MaxCount)
				 begin 
					   update [CustomerInfo] with(rowlock) set [EmployeeID]=@UserID,AllocateTime=getdate() where [CustomerID]=@CustomerID;
					   set @totalCount=@totalCount+1;
					   update AllocatePhoneDetailInfo set [AllocateTime]=getdate(), [TotalCount]=@totalCount where UserID=@UserID and [PhoneType]=@PhoneType ;
					   /*修改被除掉一个电话的业务员*/
					   update AllocatePhoneDetailInfo set [AllocateTime]=getdate(), [TotalCount]=(case  when [TotalCount]>0 then [TotalCount]-1 else 0 end) where UserID=@employeeIDOld and [PhoneType]=@PhoneType ;
					    if(@@error=0)
						  set @return=1;--分配成功
				 end
				 else
			 begin
			   if(@totalCount>=@MaxCount)
			   set @return=2;--已经超过最大的值了
			   if(@allocateCount>=@DailyMaxCount)
			   set @return=3;--已经超过当天的最大的值了
			 end
	 	 
		if(@@error=0)
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

