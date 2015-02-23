CREATE PROCEDURE [dbo].[sp_InsertDocument]
(
	@MedicalTestID int,
	@FileName nvarchar(50)
)
AS
BEGIN
	
	DECLARE @DocumentID int

	INSERT INTO [dbo].[Document]
           ([MedicalTestID]
           ,[FileName]
		   ,AddedDate)
	VALUES
	(
		@MedicalTestID,
		@FileName,
		GETDATE()
	)

	SET @DocumentID = (SELECT @@Identity)
	RETURN ISNULL(@DocumentID, 0)

END