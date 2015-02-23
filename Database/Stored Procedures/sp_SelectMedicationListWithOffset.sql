CREATE PROCEDURE [dbo].[sp_SelectMedicationListWithOffset]
(
	@Offset int,
	@CountRows int
)
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName,
	'Видалити' AS DeleteColumn
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	ORDER BY
		Medication.Name
	OFFSET @Offset ROWS
	FETCH NEXT @CountRows ROWS ONLY

END