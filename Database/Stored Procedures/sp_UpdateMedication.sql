CREATE PROCEDURE [dbo].[sp_UpdateMedication]
(
	@MedicationID int,
	@Name nvarchar(50),
	@MedicationFormID int
)
AS
BEGIN
	
	UPDATE
		Medication
	SET
		Name = @Name,
		MedicationFormID = @MedicationFormID
	WHERE
		MedicationID = @MedicationID

END