CREATE PROCEDURE [dbo].[sp_UpdateMedicationCountInStock]
(
	@MedicationID int
)
AS
BEGIN
	
	DECLARE @CountInStock int,
		@CountGave int

	SET @CountGave = 0
	SET @CountInStock = 0

	SELECT
		@CountInStock = ISNULL(SUM(Count), 0)
	FROM
		MedicationFlow
	WHERE
		MedicationID = @MedicationID
		AND
		MedicationFlowTypeID = 1

	SELECT
		@CountGave = ISNULL(SUM(Count), 0)
	FROM
		MedicationFlow
	WHERE
		MedicationID = @MedicationID
		AND
		MedicationFlowTypeID = 2

	SET @CountInStock = @CountInStock - @CountGave

	UPDATE
		Medication
	SET
		CountInStock = @CountInStock
	WHERE
		MedicationID = @MedicationID

END