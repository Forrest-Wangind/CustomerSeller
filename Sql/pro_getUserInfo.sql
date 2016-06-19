USE [CustomerSeller]
GO

/****** Object:  StoredProcedure [dbo].[pro_getUserInfo]    Script Date: 2016/6/19 12:59:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
	IF OBJECT_ID ( 'pro_getUsers', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getUserInfo;
	GO
	 CREATE procedure [dbo].[pro_getUserInfo](@UserID nvarchar(50),@Password nvarchar(50))
	 as
	   begin
	        begin try
			      
	if exists(select 1  from [dbo].[UserInfo] where UserID=@UserID and [Password]=@Password and [UserStatus]<>1)
begin
     begin tran UserLogin
	 update [dbo].[UserInfo] set [UserStatus]=1 where  UserID=@UserID and [Password]=@Password;
     select UserID,Exten,U.RoleID,RoleName,UserName ,Exten from [dbo].[UserInfo] U inner join [dbo].[RoleInfo] R on U.RoleID=R.RoleID where
	 UserID=@UserID and [Password]=@Password;
	 if @@rowcount>0
	     commit tran UserLogin;
     else
		 rollback tran UserLogin;
end
else
     begin
	 if exists(select 1  from [dbo].[UserInfo] where UserID=@UserID and [Password]=@Password) 
               select -3;--该员工已经登录不可重复登录，先退出之前的账号
	 else
	           select -1;
	 end
			end try
			begin catch
			   select -2;
			end catch
	   end
GO

select 1  from [dbo].[UserInfo] where UserID='T04471' and [Password]='Oq+TK1ZEl1Q=' and [UserStatus]<>1
print 1
select *  from [dbo].[UserInfo] where UserID='T04471'