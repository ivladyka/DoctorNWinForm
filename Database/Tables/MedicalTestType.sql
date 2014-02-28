CREATE TABLE [dbo].[MedicalTestType] (
    [MedicalTestTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_MedicalTestType] PRIMARY KEY CLUSTERED ([MedicalTestTypeID] ASC)
);

