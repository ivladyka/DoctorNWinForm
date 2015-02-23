CREATE PROCEDURE [dbo].[sp_SelectMedicationList]
(
	@Name nvarchar(50)
)
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName,
	Medication.Name + ' - ' + MedicationForm.Name AS MedicationFullName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		Medication.Name LIKE @Name + '%' OR @Name = ''
	ORDER BY
		Medication.Name

END