CREATE PROCEDURE dbo.sp_SelectPatient
(
	@PatientID int
)
AS
BEGIN
	
	SELECT 
		*
	FROM 
		[dbo].[Patient]
	WHERE
		PatientID = @PatientID

END