CREATE PROCEDURE dbo.[sp_DeletePatient]
(
	@PatientID int
)
AS
BEGIN
	
	BEGIN TRANSACTION DeletePatientFullInfo

	DELETE
		MedicalTest
	FROM
		MedicalTest mt INNER JOIN Visit ON mt.VisitID = Visit.VisitID
	WHERE
		Visit.PatientID = @PatientID

	DELETE
		Visit
	WHERE
		PatientID = @PatientID

	DELETE FROM 
		[dbo].[Patient]
	WHERE
		PatientID = @PatientID

	COMMIT TRANSACTION DeletePatientFullInfo

END