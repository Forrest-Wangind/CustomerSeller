USE [CustomerSeller]
GO
/****** Object:  StoredProcedure [dbo].[RecycleCustomerPhone]    Script Date: 2016/7/2 17:33:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --回收电话
 ALTER procedure [dbo].[RecycleCustomerPhone] (@CustomerID uniqueidentifier,@UserID nvarchar(50))
 as
    begin
	     begin tran t1;
		 declare @PhoneType varchar(10);
	     declare @totalCount int;
	     declare @return int;
	     declare @error int;
		 select @return=-1,@error=0;
		 if(@UserID<>'')
		    select @PhoneType=[PhoneType] from CustomerInfo where [CustomerID]=@CustomerID;
		 else
		    select @PhoneType=[PhoneType],@UserID=EmployeeID from CustomerInfo where [CustomerID]=@CustomerID;
		 if(@CustomerID is not null)
		 begin
			 update CustomerInfo set EmployeeID=null,RecycleTime=GETDATE(),AllocateTime=null,Remark=null,[PhoneStratus]=null where CustomerID=@CustomerID;
			 set @error+=@@ERROR;
			 if(exists(select 1 from AllocatePhoneDetailInfo where UserID=@UserID and [PhoneType]=@PhoneType))
			 begin 
				 update AllocatePhoneDetailInfo set  TotalCount=(case  when TotalCount<=0 then 0 else TotalCount-1 end) where UserID=@UserID and [PhoneType]=@PhoneType ;
				 set @error+=@@ERROR;
			 end
			 if(@error=0)
			 set @return=1;--回收时间
		 end
		 --end
		 else
		 set @return=-1;
		 if(@error=0)
		 begin
		     commit tran t1;
		     select @return;
		 end
		 else
		     begin
			 rollback tran t1;
			 select @return;
			 end	
	end