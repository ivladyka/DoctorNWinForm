CREATE TABLE [dbo].[Patient] (
    [PatientID]  INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (50)  NOT NULL,
    [LastName]   NVARCHAR (50)  NOT NULL,
    [MiddleName] NVARCHAR (50)  NULL,
    [Birthday]   SMALLDATETIME  NULL,
    [Notes]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED ([PatientID] ASC)
);

