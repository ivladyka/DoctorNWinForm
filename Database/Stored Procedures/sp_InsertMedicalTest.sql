
CREATE PROCEDURE dbo.sp_InsertMedicalTest
(
	@MedicalTestTypeID int,
	@FileName nvarchar(50),
	@VisitID int,
	@Date smalldatetime
)
AS
BEGIN
	
	DECLARE @MedicalTestID int

	INSERT INTO [dbo].[MedicalTest]
           ([MedicalTestTypeID]
           ,[FileName]
           ,[VisitID]
           ,[Date])
     VALUES
           (@MedicalTestTypeID
           ,@FileName
           ,@VisitID
           ,@Date)

	SET @MedicalTestID = (SELECT @@Identity)
	RETURN ISNULL(@MedicalTestID, 0)

END