CREATE PROCEDURE [dbo].[sp_SelectMedicationCount]
AS
BEGIN
	
	DECLARE @MedicationCount int

	SET @MedicationCount = 0

	SELECT
		@MedicationCount = Count(MedicationID)
	FROM
		Medication

	RETURN @MedicationCount

END