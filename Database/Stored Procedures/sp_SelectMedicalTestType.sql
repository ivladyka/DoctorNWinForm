CREATE PROCEDURE [dbo].[sp_SelectMedicalTestType]
(
	@MedicalTestTypeID int
)
AS
BEGIN
	
	SELECT
	*
	FROM
		MedicalTestType
	WHERE
		MedicalTestTypeID = @MedicalTestTypeID

END