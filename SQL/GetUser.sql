USE [HealthMonitoring]
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 09.03.2020 22:19:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE GetUser 
 @Login NVARCHAR(50)
AS
BEGIN
	SELECT IdUser, UserName, UserSurname, Role FROM Users WHERE Login = @Login
END
