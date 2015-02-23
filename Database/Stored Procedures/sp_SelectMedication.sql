CREATE PROCEDURE [dbo].[sp_SelectMedication]
(
	@MedicationID int
)
AS
BEGIN
	
	SELECT
		Medication.*,
		Medication.Name + ' - ' + MedicationForm.Name AS MedicationFullName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		Medication.MedicationID = @MedicationID

END