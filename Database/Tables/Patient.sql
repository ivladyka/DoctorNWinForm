CREATE TABLE [dbo].[Patient] (
    [PatientID]      INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]      NVARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [LastName]       NVARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [MiddleName]     NVARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Birthday]       SMALLDATETIME  NULL,
    [Notes]          NVARCHAR (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Education]      NVARCHAR (50)  NULL,
    [WorkPosition]   NVARCHAR (50)  NULL,
    [Phone]          NVARCHAR (50)  NULL,
    [FinancialNotes] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED ([PatientID] ASC)
);



