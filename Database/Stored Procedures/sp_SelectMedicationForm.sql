CREATE PROCEDURE [dbo].[sp_SelectMedicationForm]
(
	@MedicationFormID int
)
AS
BEGIN
	
	SELECT
	*
	FROM
		MedicationForm
	WHERE
		MedicationFormID = @MedicationFormID

END