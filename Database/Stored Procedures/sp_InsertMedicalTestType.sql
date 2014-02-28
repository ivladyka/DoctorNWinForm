
CREATE PROCEDURE [dbo].[sp_InsertMedicalTestType]
(
	@Name nvarchar(50)
)
AS
BEGIN
	
	INSERT INTO MedicalTestType
	(
		Name
	)
	VALUES
	(
		@Name
	)

END