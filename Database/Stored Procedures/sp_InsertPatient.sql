CREATE PROCEDURE [dbo].[sp_InsertPatient]
(
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50),
	@Birthday smalldatetime,
	@Notes nvarchar(max)
)
AS
BEGIN

	DECLARE @PatientID int

	INSERT INTO [dbo].[Patient]
           ([FirstName]
           ,[LastName]
           ,[MiddleName]
           ,[Birthday]
           ,[Notes])
     VALUES
           (@FirstName
           ,@LastName
           ,@MiddleName
           ,@Birthday
           ,@Notes)

	SET @PatientID = (SELECT @@Identity)
	RETURN ISNULL(@PatientID, 0)
END