CREATE PROCEDURE [dbo].[sp_InsertPatient]
(
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

	DECLARE @PatientID int

	INSERT INTO [dbo].[Patient]
           ([FirstName]
           ,[LastName]
           ,[MiddleName]
           ,[Birthday]
           ,[Notes]
		   ,Education
		   ,WorkPosition
		   ,Phone
		   ,FinancialNotes)
     VALUES
           (@FirstName
           ,@LastName
           ,@MiddleName
           ,@Birthday
           ,@Notes
		   ,@Education
		   ,@WorkPosition
		   ,@Phone
		   ,@FinancialNotes)

	SET @PatientID = (SELECT @@Identity)
	RETURN ISNULL(@PatientID, 0)
END