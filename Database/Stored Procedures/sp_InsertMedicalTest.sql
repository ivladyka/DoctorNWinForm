
CREATE PROCEDURE [dbo].[sp_InsertMedicalTest]
(
	@MedicalTestTypeID int,
	@VisitID int,
	@Date smalldatetime
)
AS
BEGIN
	
	DECLARE @MedicalTestID int

	INSERT INTO [dbo].[MedicalTest]
           ([MedicalTestTypeID]
           ,[VisitID]
           ,[Date])
     VALUES
           (@MedicalTestTypeID
           ,@VisitID
           ,@Date)

	SET @MedicalTestID = (SELECT @@Identity)
	RETURN ISNULL(@MedicalTestID, 0)

END