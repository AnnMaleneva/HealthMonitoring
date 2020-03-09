SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE AddUser 
	@UserName NVARCHAR(50),
	@UserSurname NVARCHAR(100),
	@DateOfBirth DATE,
	@Login NVARCHAR(50),
	@Password NVARCHAR(6)
AS
BEGIN
	INSERT INTO Users (UserName, UserSurname, DateOfBirth, Login, Password)
	VALUES (@UserName, @UserSurname, @DateOfBirth, @Login, @Password)
END
GO
