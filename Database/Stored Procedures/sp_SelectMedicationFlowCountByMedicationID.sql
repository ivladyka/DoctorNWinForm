CREATE PROCEDURE [dbo].[sp_SelectMedicationFlowCountByMedicationID]
(
	@MedicationID int
)
AS
BEGIN
	
	DECLARE @MedicationFlowCount int

	SET @MedicationFlowCount = 0

	SELECT
		@MedicationFlowCount = Count(MedicationID)
	FROM
		MedicationFlow
	WHERE
		MedicationID = @MedicationID

	RETURN @MedicationFlowCount

END