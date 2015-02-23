CREATE PROCEDURE [dbo].[sp_SelectMedicationFlowListByMedicationIDWithOffset]
(
	@MedicationID int,
	@Offset int,
	@CountRows int
)
AS
BEGIN
	
	SELECT
	MedicationFlow.*,
	MedicationFlowType.Name AS MedicationFlowTypeName,
	'Видалити' AS DeleteColumn
	FROM
		MedicationFlow
	INNER JOIN
        MedicationFlowType ON MedicationFlow.MedicationFlowTypeID = MedicationFlowType.MedicationFlowTypeID
	WHERE
		MedicationFlow.MedicationID = @MedicationID
	ORDER BY
		MedicationFlow.Date DESC
	OFFSET @Offset ROWS
	FETCH NEXT @CountRows ROWS ONLY

END