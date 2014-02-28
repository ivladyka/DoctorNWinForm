CREATE PROCEDURE [dbo].[sp_DeleteMedicalTest]
(
	@MedicalTestID int
)
AS
BEGIN
	
	DELETE 
		MedicalTest
	WHERE
		MedicalTestID = @MedicalTestID

END