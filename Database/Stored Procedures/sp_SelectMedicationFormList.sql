
CREATE PROCEDURE [dbo].[sp_SelectMedicationFormList]
AS
BEGIN
	
	SELECT
	*,
	'Видалити' AS DeleteColumn
	FROM
		MedicationForm
	ORDER BY
		Name

END