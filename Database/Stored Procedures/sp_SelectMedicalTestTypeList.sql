CREATE PROCEDURE [dbo].[sp_SelectMedicalTestTypeList]
AS
BEGIN
	
	SELECT
	*,
	'Видалити' AS DeleteColumn
	FROM
		MedicalTestType
	ORDER BY
		Name
END