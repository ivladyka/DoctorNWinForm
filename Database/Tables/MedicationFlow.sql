CREATE TABLE [dbo].[MedicationFlow] (
    [MedicationFlowID]     INT           IDENTITY (1, 1) NOT NULL,
    [MedicationFlowTypeID] INT           NOT NULL,
    [MedicationID]         INT           NOT NULL,
    [Count]                INT           NOT NULL,
    [Date]                 SMALLDATETIME NOT NULL,
    [Note]                 NVARCHAR (50) NULL,
    CONSTRAINT [PK_MedicationFlow] PRIMARY KEY CLUSTERED ([MedicationFlowID] ASC),
    CONSTRAINT [FK_MedicationFlow_Medication] FOREIGN KEY ([MedicationID]) REFERENCES [dbo].[Medication] ([MedicationID]),
    CONSTRAINT [FK_MedicationFlow_MedicationFlowType] FOREIGN KEY ([MedicationFlowTypeID]) REFERENCES [dbo].[MedicationFlowType] ([MedicationFlowTypeID])
);

