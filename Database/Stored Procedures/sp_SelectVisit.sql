CREATE PROCEDURE [dbo].[sp_SelectVisit]
(
	@VisitID int
)
AS
BEGIN
	
	SELECT 
		*
	FROM 
		[dbo].[Visit]
	WHERE
		VisitID = @VisitID

END