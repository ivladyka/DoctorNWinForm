CREATE PROCEDURE [dbo].[sp_DeleteVisit]
(
	@VisitID int
)
AS
BEGIN
	
	BEGIN TRANSACTION DeleteVisitFullInfo

	DELETE
		Document
	FROM
		Document d INNER JOIN MedicalTest ON d.MedicalTestID = MedicalTest.MedicalTestID
	WHERE
		MedicalTest.VisitID = @VisitID

	DELETE
		MedicalTest
	WHERE
		VisitID = @VisitID

	DELETE
		Visit
	WHERE
		VisitID = @VisitID

	COMMIT TRANSACTION DeleteVisitFullInfo

END