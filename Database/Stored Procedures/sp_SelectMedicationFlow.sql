CREATE PROCEDURE [dbo].[sp_SelectMedicationFlow]
(
	@MedicationFlowID int
)
AS
BEGIN
	
	SELECT
	*
	FROM
		MedicationFlow
	WHERE
		MedicationFlowID = @MedicationFlowID

END