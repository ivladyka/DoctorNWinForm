CREATE PROCEDURE [dbo].[sp_UpdateReminder]
(
	@ReminderID int,
	@PatientID int,
	@Date smalldatetime,
	@Notes nvarchar(MAX)
)
AS
BEGIN
	
	UPDATE
		Reminder
	SET
		PatientID = @PatientID,
		[Date] = @Date,
		Notes = @Notes
	WHERE
		ReminderID = @ReminderID

END