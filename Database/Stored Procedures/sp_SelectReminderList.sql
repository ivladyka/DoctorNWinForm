CREATE PROCEDURE [dbo].[sp_SelectReminderList]
AS
BEGIN
	
	SELECT
	Reminder.*,
	ISNULL(Patient.LastName + ' ' , '') + ISNULL(Patient.FirstName, '') AS PatientName,
	'Видалити' AS DeleteColumn
	FROM
		Reminder
	LEFT OUTER JOIN
        Patient ON Reminder.PatientID = Patient.PatientID
	ORDER BY
		Reminder.Date

END