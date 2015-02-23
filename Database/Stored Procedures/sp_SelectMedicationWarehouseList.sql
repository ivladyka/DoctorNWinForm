CREATE PROCEDURE [dbo].[sp_SelectMedicationWarehouseList]
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		CountInStock <> 0
	ORDER BY
		Medication.Name

END