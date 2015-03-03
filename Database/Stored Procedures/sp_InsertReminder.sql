CREATE PROCEDURE [dbo].[sp_InsertReminder]
(
	@PatientID int,
	@Date smalldatetime,
	@Notes nvarchar(MAX)
)
AS
BEGIN
	
	INSERT INTO Reminder
	(
		PatientID,
		[Date],
		Notes
	)
	VALUES
	(
		@PatientID,
		@Date,
		@Notes
	)

END