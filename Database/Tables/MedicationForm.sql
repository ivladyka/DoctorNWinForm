CREATE TABLE [dbo].[MedicationForm] (
    [MedicationFormID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_MedicationForm] PRIMARY KEY CLUSTERED ([MedicationFormID] ASC)
);

