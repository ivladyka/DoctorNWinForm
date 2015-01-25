CREATE PROCEDURE [dbo].[sp_UpdatePatient]
(
	@PatientID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50),
	@Birthday smalldatetime,
	@Notes nvarchar(max),
	@Education nvarchar(50),
	@WorkPosition nvarchar(50),
	@Phone nvarchar(50),
	@FinancialNotes nvarchar(max)
)
AS
BEGIN
	
	UPDATE [dbo].[Patient]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[MiddleName] = @MiddleName
      ,[Birthday] = @Birthday
      ,[Notes] = @Notes
	  ,Education = @Education
	  ,WorkPosition = @WorkPosition
	  ,Phone = @Phone
	  ,FinancialNotes = @FinancialNotes
	WHERE 
		PatientID = @PatientID

END