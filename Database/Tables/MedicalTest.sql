CREATE TABLE [dbo].[MedicalTest] (
    [MedicalTestID]     INT           IDENTITY (1, 1) NOT NULL,
    [MedicalTestTypeID] INT           NOT NULL,
    [FileName]          NVARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [VisitID]           INT           NOT NULL,
    [Date]              SMALLDATETIME NOT NULL,
    CONSTRAINT [PK_MedicalTest] PRIMARY KEY CLUSTERED ([MedicalTestID] ASC),
    CONSTRAINT [FK_MedicalTest_MedicalTestType] FOREIGN KEY ([MedicalTestTypeID]) REFERENCES [dbo].[MedicalTestType] ([MedicalTestTypeID]),
    CONSTRAINT [FK_MedicalTest_Visit] FOREIGN KEY ([VisitID]) REFERENCES [dbo].[Visit] ([VisitID])
);



