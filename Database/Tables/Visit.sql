CREATE TABLE [dbo].[Visit] (
    [VisitID]      INT           IDENTITY (1, 1) NOT NULL,
    [PatientID]    INT           NOT NULL,
    [Date]         SMALLDATETIME NOT NULL,
    [Anamnesis]    NTEXT         NULL,
    [Prescription] NTEXT         NULL,
    CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED ([VisitID] ASC),
    CONSTRAINT [FK_Visit_Patient] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient] ([PatientID])
);

