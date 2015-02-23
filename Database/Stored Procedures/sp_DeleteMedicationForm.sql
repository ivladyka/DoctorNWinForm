CREATE PROCEDURE [dbo].[sp_DeleteMedicationForm]
(
	@MedicationFormID int
)
AS
BEGIN
	
	DELETE 
		MedicationForm
	WHERE
		MedicationFormID = @MedicationFormID

END