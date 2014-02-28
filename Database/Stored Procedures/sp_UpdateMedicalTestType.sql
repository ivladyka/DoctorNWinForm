CREATE PROCEDURE [dbo].[sp_UpdateMedicalTestType]
(
	@MedicalTestTypeID int,
	@Name nvarchar(50)
)
AS
BEGIN
	
	UPDATE
		MedicalTestType
	SET
		Name = @Name
	WHERE
		MedicalTestTypeID = @MedicalTestTypeID

END