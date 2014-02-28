CREATE PROCEDURE [dbo].[sp_DeleteMedicalTestType]
(
	@MedicalTestTypeID int
)
AS
BEGIN
	
	DELETE 
		MedicalTestType
	WHERE
		MedicalTestTypeID = @MedicalTestTypeID

END