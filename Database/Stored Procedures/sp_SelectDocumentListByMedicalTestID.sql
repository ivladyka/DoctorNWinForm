
CREATE PROCEDURE [dbo].[sp_SelectDocumentListByMedicalTestID]
(
	@MedicalTestID int
)
AS
BEGIN
	
	SELECT 
		DocumentID,
		[FileName],
		'Видалити' AS DeleteColumn
	FROM 
		[Document] 
	WHERE 
		MedicalTestID = @MedicalTestID
	ORDER BY
		AddedDate

END