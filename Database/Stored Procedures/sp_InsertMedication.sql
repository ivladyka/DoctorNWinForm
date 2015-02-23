
CREATE PROCEDURE [dbo].[sp_InsertMedication]
(
	@Name nvarchar(50),
	@MedicationFormID int
)
AS
BEGIN
	
	INSERT INTO Medication
	(
		Name,
		MedicationFormID
	)
	VALUES
	(
		@Name,
		@MedicationFormID
	)

END