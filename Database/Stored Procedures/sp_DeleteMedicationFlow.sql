CREATE PROCEDURE [dbo].[sp_DeleteMedicationFlow] 
(
	@MedicationFlowID int
)
AS
BEGIN
	
	DECLARE @MedicationID  int

	SELECT
		@MedicationID = MedicationID
	FROM
		MedicationFlow
	WHERE
		MedicationFlowID = @MedicationFlowID

	DELETE 
		MedicationFlow
	WHERE
		MedicationFlowID = @MedicationFlowID

	exec dbo.sp_UpdateMedicationCountInStock @MedicationID

END