CREATE PROCEDURE [dbo].[sp_UpdateMedicalTest]
(
	@MedicalTestID int,
	@MedicalTestTypeID int,
	@Date smalldatetime
)
AS
BEGIN
	
	UPDATE 
		[dbo].[MedicalTest]
    SET 
		[MedicalTestTypeID] = @MedicalTestTypeID
      ,[Date] = @Date
	WHERE 
		MedicalTestID = @MedicalTestID

END