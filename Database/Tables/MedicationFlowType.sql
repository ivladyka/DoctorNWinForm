CREATE TABLE [dbo].[MedicationFlowType] (
    [MedicationFlowTypeID] INT           NOT NULL,
    [Name]                 NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_MedicationFlowType] PRIMARY KEY CLUSTERED ([MedicationFlowTypeID] ASC)
);

