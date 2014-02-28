CREATE PROCEDURE dbo.sp_SelectMedicalTest
(
	@MedicalTestID int
)
AS
BEGIN
	
  SELECT 
		*
  FROM 
	[dbo].[MedicalTest]
  WHERE
	MedicalTestID = @MedicalTestID

END