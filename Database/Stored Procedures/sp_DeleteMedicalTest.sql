CREATE PROCEDURE [dbo].[sp_DeleteMedicalTest]
(
	@MedicalTestID int
)
AS
BEGIN
	
	BEGIN TRANSACTION DeleteMedicalTestFullInfo

	DELETE
		Document
	WHERE
		MedicalTestID = @MedicalTestID

	DELETE 
		MedicalTest
	WHERE
		MedicalTestID = @MedicalTestID

	COMMIT TRANSACTION DeleteMedicalTestFullInfo

END