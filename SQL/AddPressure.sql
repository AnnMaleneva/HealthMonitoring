
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE AddPressure
@UserId INT,
@TopNumber INT,
@LowerNumber INT,
@Date DATE

AS
BEGIN
	INSERT INTO Pressure(User_Id, Top_pressure, Low_pressure, Date) VALUES (@UserId, @TopNumber, @LowerNumber, @Date)
END
GO