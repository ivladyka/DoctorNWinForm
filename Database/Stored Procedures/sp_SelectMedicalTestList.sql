CREATE PROCEDURE [dbo].[sp_SelectMedicalTestList]
(
	@VisitID int
)
AS
BEGIN
	
	SELECT        
		MedicalTest.MedicalTestID, 
		MedicalTest.MedicalTestTypeID, 
		dbo.fx_GetAllFilesByMedicalTestID(MedicalTest.MedicalTestID) AS AllFiles, 
		MedicalTest.Date,
		MedicalTestType.Name AS MedicalTestTypeName,
		'Видалити' AS DeleteColumn
	FROM            
		MedicalTest 
	INNER JOIN
		MedicalTestType ON MedicalTest.MedicalTestTypeID = MedicalTestType.MedicalTestTypeID
	WHERE
		MedicalTest.VisitID = @VisitID
	ORDER BY
		MedicalTest.Date DESC

END