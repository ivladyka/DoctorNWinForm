CREATE PROCEDURE [dbo].[sp_UpdateMedicationForm]
(
	@MedicationFormID int,
	@Name nvarchar(50)
)
AS
BEGIN
	
	UPDATE
		MedicationForm
	SET
		Name = @Name
	WHERE
		MedicationFormID = @MedicationFormID

END