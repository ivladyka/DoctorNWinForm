CREATE PROCEDURE [dbo].[sp_DeleteReminder]
(
	@ReminderID int
)
AS
BEGIN
	
	DELETE 
		Reminder
	WHERE
		ReminderID = @ReminderID

END