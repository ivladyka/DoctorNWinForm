
CREATE PROCEDURE [dbo].[sp_SelectVisitList]
(
	@PatientID int
)
AS
BEGIN
	
	SELECT 
		[VisitID]
      ,[Date]
      ,[Anamnesis]
      ,[Prescription]
	  ,'Видалити' AS DeleteColumn
	FROM 
		[dbo].[Visit]
	WHERE
		PatientID = @PatientID

END