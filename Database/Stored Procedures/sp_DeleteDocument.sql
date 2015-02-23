CREATE PROCEDURE [dbo].[sp_DeleteDocument]
(
	@DocumentID int
)
AS
BEGIN
	
	DELETE
		Document
	WHERE
		DocumentID = @DocumentID

END