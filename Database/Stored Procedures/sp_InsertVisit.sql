CREATE PROCEDURE [dbo].[sp_InsertVisit]
(
	@PatientID int,
	@Date smalldatetime,
	@Anamnesis ntext,
	@Prescription ntext
)
AS
BEGIN
	
	DECLARE @VisitID int

	INSERT INTO Visit
	(
		[PatientID]
       ,[Date]
       ,[Anamnesis]
       ,[Prescription]
	)
	VALUES
	(
		@PatientID,
		@Date,
		@Anamnesis,
		@Prescription
	)

	SET @VisitID = (SELECT @@Identity)
	RETURN ISNULL(@VisitID, 0)

END