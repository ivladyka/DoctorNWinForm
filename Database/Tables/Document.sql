CREATE TABLE [dbo].[Document] (
    [DocumentID]    INT           IDENTITY (1, 1) NOT NULL,
    [MedicalTestID] INT           NOT NULL,
    [FileName]      NVARCHAR (50) NOT NULL,
    [AddedDate]     SMALLDATETIME CONSTRAINT [DF_Document_AddedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED ([DocumentID] ASC),
    CONSTRAINT [FK_Document_MedicalTest] FOREIGN KEY ([MedicalTestID]) REFERENCES [dbo].[MedicalTest] ([MedicalTestID])
);



