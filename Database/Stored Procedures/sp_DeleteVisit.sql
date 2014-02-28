CREATE PROCEDURE [dbo].[sp_DeleteVisit]
(
	@VisitID int
)
AS
BEGIN
	
	BEGIN TRANSACTION DeleteVisitFullInfo

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