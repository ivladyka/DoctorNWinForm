CREATE PROCEDURE [dbo].[sp_SelectMedicationFlowTypeList]
AS
BEGIN
	
	SELECT
		*
	FROM
		MedicationFlowType
	ORDER BY
		MedicationFlowType.Name

END