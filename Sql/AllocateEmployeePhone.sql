USE [CustomerSeller]
GO
/****** Object:  StoredProcedure [dbo].[AllocateEmployeePhone]    Script Date: 2016/4/10 19:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--分配电话资源
ALTER procedure [dbo].[AllocateEmployeePhone] (@MaxCount int,@DailyMaxCount int,@UserID nvarchar(50),@PhoneType varchar(10))
as
begin
begin tran t1
declare @allocateTime as datetime;
declare @allocateCount as int;
declare @totalCount as int;
declare @return as int;
declare @error as int;

begin try
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
	     
	         update CustomerInfo set EmployeeID=@UserID,AllocateTime=GETDATE()  where CustomerID=(
				select top 1 CustomerID from CustomerInfo with (rowlock) where EmployeeID is null and (PhoneStratus<>'已成交' or PhoneStratus is null) and [PhoneType]=@PhoneType order by CreateTime desc
				)
		    if(@@rowcount<>0)
			 begin
			 set @allocateCount=@allocateCount+1;
			 set @totalCount=@totalCount+1;
			 update AllocatePhoneDetailInfo set [DailyCount]=@allocateCount,[AllocateTime]=getdate(), [TotalCount]=@totalCount where UserID=@UserID and [PhoneType]=@PhoneType ;
			 if(@@error=0)
			  set @return=1;--分配成功
			  end
			else
			 set @return=0;--没有电话资源
	 end
	 else
	 begin
	   if(@totalCount>=@MaxCount)
	   set @return=2;--已经超过最大的值了
	   if(@allocateCount>=@DailyMaxCount)
	   set @return=3;--已经超过当天的最大的值了
	 end
end try
begin catch
 set @return=-1;
 select @return;
 rollback tran t1
 end catch

 if(@@error=0)
 begin
 select @return;
 commit tran t1
 end
 end

