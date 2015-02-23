CREATE TABLE [dbo].[Medication] (
    [MedicationID]     INT           IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (50) NOT NULL,
    [MedicationFormID] INT           NOT NULL,
    [CountInStock]     INT           CONSTRAINT [DF_Medication_CountInStock] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Medication] PRIMARY KEY CLUSTERED ([MedicationID] ASC),
    CONSTRAINT [FK_Medication_MedicationForm] FOREIGN KEY ([MedicationFormID]) REFERENCES [dbo].[MedicationForm] ([MedicationFormID])
);

