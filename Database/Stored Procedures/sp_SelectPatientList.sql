CREATE PROCEDURE [dbo].[sp_SelectPatientList]
(
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
)
AS
BEGIN
	
	SELECT 
		*,
		'Видалити' AS DeleteColumn
    FROM [dbo].[Patient]
	WHERE
		FirstName LIKE @FirstName + '%'
		AND
		LastName LIKE @LastName + '%'

END