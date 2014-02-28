CREATE PROCEDURE [dbo].[sp_SelectMedicalTestList]
(
	@VisitID int
)
AS
BEGIN
	
	SELECT        
		MedicalTest.MedicalTestID, 
		MedicalTest.MedicalTestTypeID, 
		MedicalTest.FileName, 
		MedicalTest.Date,
		MedicalTestType.Name AS MedicalTestTypeName,
		'Видалити' AS DeleteColumn,
		'Проглянути' AS ViewColumn
	FROM            
		MedicalTest 
	INNER JOIN
		MedicalTestType ON MedicalTest.MedicalTestTypeID = MedicalTestType.MedicalTestTypeID
	WHERE
		MedicalTest.VisitID = @VisitID

END