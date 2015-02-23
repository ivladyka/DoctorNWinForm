CREATE PROCEDURE [dbo].[sp_DeleteMedication]
(
	@MedicationID int
)
AS
BEGIN
	
	DELETE 
		Medication
	WHERE
		MedicationID = @MedicationID

END