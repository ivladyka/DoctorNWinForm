
CREATE FUNCTION [dbo].[fx_GetAllFilesByMedicalTestID]
(
	@MedicalTestID int
)
RETURNS nvarchar(max)
AS
BEGIN
	
	DECLARE @AllFiles nvarchar(max)

	SET @AllFiles = ''
	DECLARE @FileName nvarchar(50)
	DECLARE l_cursor CURSOR FOR SELECT [FileName] FROM [Document] WHERE MedicalTestID=@MedicalTestID
	OPEN l_cursor
	FETCH NEXT FROM l_cursor INTO @FileName
	WHILE @@FETCH_STATUS = 0
	BEGIN	
	    IF @AllFiles = ''
		 BEGIN
			SET @AllFiles = @FileName
		 END
		ELSE
		 BEGIN
			SET @AllFiles = @AllFiles + ',' + 	@FileName
		 END
		FETCH NEXT FROM l_cursor INTO @FileName
	END
	CLOSE l_cursor
	DEALLOCATE l_cursor

	RETURN @AllFiles

END