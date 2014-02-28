CREATE PROCEDURE [dbo].[sp_UpdatePatient]
(
	@PatientID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50),
	@Birthday smalldatetime,
	@Notes nvarchar(max)
)
AS
BEGIN
	
	UPDATE [dbo].[Patient]
   SET [FirstName] = @FirstName
      ,[LastName] = @FirstName
      ,[MiddleName] = @MiddleName
      ,[Birthday] = @Birthday
      ,[Notes] = @Notes
	WHERE 
		PatientID = @PatientID

END