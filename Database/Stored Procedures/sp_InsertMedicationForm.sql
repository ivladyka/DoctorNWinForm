CREATE PROCEDURE [dbo].[sp_InsertMedicationForm]
(
	@Name nvarchar(50)
)
AS
BEGIN
	
	INSERT INTO MedicationForm
	(
		Name
	)
	VALUES
	(
		@Name
	)

END