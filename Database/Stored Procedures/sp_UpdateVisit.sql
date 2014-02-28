CREATE PROCEDURE [dbo].[sp_UpdateVisit]
(
	@VisitID int,
	@Date smalldatetime,
	@Anamnesis ntext,
	@Prescription ntext
)
AS
BEGIN
	
	UPDATE 
		[dbo].[Visit]
    SET [Date] = @Date
      ,[Anamnesis] = @Anamnesis
      ,[Prescription] = @Prescription
	WHERE 
		VisitID = @VisitID

END