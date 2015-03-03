CREATE TABLE [dbo].[Reminder] (
    [ReminderID] INT            IDENTITY (1, 1) NOT NULL,
    [Date]       SMALLDATETIME  NOT NULL,
    [PatientID]  INT            NULL,
    [Notes]      NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Reminder] PRIMARY KEY CLUSTERED ([ReminderID] ASC),
    CONSTRAINT [FK_Reminder_Patient] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient] ([PatientID])
);

