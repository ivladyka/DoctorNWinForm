CREATE PROCEDURE [dbo].[sp_SelectReminder]
(
	@ReminderID int
)
AS
BEGIN
	
	SELECT
		Reminder.*,
		ISNULL(Patient.LastName + ' ' , '') + ISNULL(Patient.FirstName, '') AS PatientName
	FROM
		Reminder
	LEFT OUTER JOIN
        Patient ON Reminder.PatientID = Patient.PatientID
	WHERE
		ReminderID = @ReminderID

END