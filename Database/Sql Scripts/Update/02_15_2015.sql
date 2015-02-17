﻿/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.MedicationForm
	(
	MedicationFormID int NOT NULL IDENTITY (1, 1),
	Name nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.MedicationForm ADD CONSTRAINT
	PK_MedicationForm PRIMARY KEY CLUSTERED 
	(
	MedicationFormID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MedicationForm SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedicationForm SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Medication
	(
	MedicationID int NOT NULL IDENTITY (1, 1),
	Name nvarchar(50) NOT NULL,
	MedicationFormID int NOT NULL,
	CountInStock int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Medication ADD CONSTRAINT
	DF_Medication_CountInStock DEFAULT 0 FOR CountInStock
GO
ALTER TABLE dbo.Medication ADD CONSTRAINT
	PK_Medication PRIMARY KEY CLUSTERED 
	(
	MedicationID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Medication ADD CONSTRAINT
	FK_Medication_MedicationForm FOREIGN KEY
	(
	MedicationFormID
	) REFERENCES dbo.MedicationForm
	(
	MedicationFormID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Medication SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.MedicationFlowType
	(
	MedicationFlowTypeID int NOT NULL,
	Name nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.MedicationFlowType ADD CONSTRAINT
	PK_MedicationFlowType PRIMARY KEY CLUSTERED 
	(
	MedicationFlowTypeID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MedicationFlowType SET (LOCK_ESCALATION = TABLE)
GO
COMMIT




INSERT INTO [dbo].[MedicationFlowType]
           ([MedicationFlowTypeID]
           ,[Name])
     VALUES
           (1
           ,'Прихід')
GO

INSERT INTO [dbo].[MedicationFlowType]
           ([MedicationFlowTypeID]
           ,[Name])
     VALUES
           (2
           ,'Розхід')
GO



/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedicationFlowType SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Medication SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
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


GO


GO
 
	
GO
 
	
GO

GO
COMMIT



INSERT INTO [dbo].[MedicationForm]
           ([Name])
     VALUES
           ('Краплі')
GO

INSERT INTO [dbo].[MedicationForm]
           ([Name])
     VALUES
           ('Свічки')
GO

INSERT INTO [dbo].[MedicationForm]
           ([Name])
     VALUES
           ('Ампули')
GO

INSERT INTO [dbo].[MedicationForm]
           ([Name])
     VALUES
           ('Капсули')
GO

INSERT INTO [dbo].[MedicationForm]
           ([Name])
     VALUES
           ('Таблетки')
GO


/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedicationFlow
	DROP CONSTRAINT FK_MedicationFlow_MedicationFlowType
GO
ALTER TABLE dbo.MedicationFlowType SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedicationFlow
	DROP CONSTRAINT FK_MedicationFlow_Medication
GO
ALTER TABLE dbo.Medication SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO

GO

GO
SET IDENTITY_INSERT dbo.Tmp_MedicationFlow ON
GO
IF EXISTS(SELECT * FROM dbo.MedicationFlow)
	 EXEC('INSERT INTO dbo.Tmp_MedicationFlow (MedicationFlowID, MedicationFlowTypeID, MedicationID, Count)
		SELECT MedicationFlowID, MedicationFlowTypeID, MedicationID, Count FROM dbo.MedicationFlow WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MedicationFlow OFF
GO
DROP TABLE dbo.MedicationFlow
GO
EXECUTE sp_rename N'dbo.Tmp_MedicationFlow', N'MedicationFlow', 'OBJECT' 
GO


GO
 
	
GO
 
	
GO
COMMIT



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SelectMedicationFormList]
AS
BEGIN
	
	SELECT
	*,
	'Видалити' AS DeleteColumn
	FROM
		MedicationForm
	ORDER BY
		Name

END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteMedicationForm]
(
	@MedicationFormID int
)
AS
BEGIN
	
	DELETE 
		MedicationForm
	WHERE
		MedicationFormID = @MedicationFormID

END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationForm]
(
	@MedicationFormID int
)
AS
BEGIN
	
	SELECT
	*
	FROM
		MedicationForm
	WHERE
		MedicationFormID = @MedicationFormID

END
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateMedicationForm]
(
	@MedicationFormID int,
	@Name nvarchar(50)
)
AS
BEGIN
	
	UPDATE
		MedicationForm
	SET
		Name = @Name
	WHERE
		MedicationFormID = @MedicationFormID

END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertMedicationForm]
(
	@Name nvarchar(50)
)
AS
BEGIN
	
	INSERT INTO MedicationForm
	(
		Name
	)
	VALUES
	(
		@Name
	)

END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationList]
(
	@Name nvarchar(50)
)
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName,
	Medication.Name + ' - ' + MedicationForm.Name AS MedicationFullName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		Medication.Name LIKE @Name + '%' OR @Name = ''
	ORDER BY
		Medication.Name

END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteMedication]
(
	@MedicationID int
)
AS
BEGIN
	
	DELETE 
		Medication
	WHERE
		MedicationID = @MedicationID

END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedication]
(
	@MedicationID int
)
AS
BEGIN
	
	SELECT
		Medication.*,
		Medication.Name + ' - ' + MedicationForm.Name AS MedicationFullName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		Medication.MedicationID = @MedicationID

END
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateMedication]
(
	@MedicationID int,
	@Name nvarchar(50),
	@MedicationFormID int
)
AS
BEGIN
	
	UPDATE
		Medication
	SET
		Name = @Name,
		MedicationFormID = @MedicationFormID
	WHERE
		MedicationID = @MedicationID

END
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertMedication]
(
	@Name nvarchar(50),
	@MedicationFormID int
)
AS
BEGIN
	
	INSERT INTO Medication
	(
		Name,
		MedicationFormID
	)
	VALUES
	(
		@Name,
		@MedicationFormID
	)

END
GO



USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMedicationList]    Script Date: 2/15/2015 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SelectMedicationList]
(
	@Offset int,
	@CountRows int
)
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName,
	'Видалити' AS DeleteColumn
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	ORDER BY
		Medication.Name
	OFFSET @Offset ROWS
	FETCH NEXT @CountRows ROWS ONLY

END

GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationCount]
AS
BEGIN
	
	DECLARE @MedicationCount int

	SET @MedicationCount = 0

	SELECT
		@MedicationCount = Count(MedicationID)
	FROM
		Medication

	RETURN @MedicationCount

END
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationWarehouseList]
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		CountInStock <> 0
	ORDER BY
		Medication.Name

END
GO



USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMedicationWarehouseList]    Script Date: 2/15/2015 10:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SelectMedicationWarehouseList]
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		CountInStock <> 0
	ORDER BY
		Medication.Name

END

GO


USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMedicationList]    Script Date: 2/15/2015 10:41:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SelectMedicationList]
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName,
	Medication.Name + ' - ' + MedicationForm.Name AS MedicationFullName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	ORDER BY
		Medication.Name

END


GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationListWithOffset]
(
	@Offset int,
	@CountRows int
)
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName,
	'Видалити' AS DeleteColumn
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	ORDER BY
		Medication.Name
	OFFSET @Offset ROWS
	FETCH NEXT @CountRows ROWS ONLY

END
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationFlowTypeList]
AS
BEGIN
	
	SELECT
		*
	FROM
		MedicationFlowType
	ORDER BY
		MedicationFlowType.Name

END
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationFlow]
(
	@MedicationFlowID int
)
AS
BEGIN
	
	SELECT
	*
	FROM
		MedicationFlow
	WHERE
		MedicationFlowID = @MedicationFlowID

END
GO


USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMedicationList]    Script Date: 2/15/2015 11:21:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SelectMedicationList]
(
	@Name nvarchar(50)
)
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName,
	Medication.Name + ' - ' + MedicationForm.Name AS MedicationFullName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		Medication.Name LIKE @Name + '%'
	ORDER BY
		Medication.Name

END

GO



USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMedicationList]    Script Date: 2/16/2015 8:18:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SelectMedicationList]
(
	@Name nvarchar(50)
)
AS
BEGIN
	
	SELECT
	Medication.*,
	MedicationForm.Name AS MedicationFormName,
	Medication.Name + ' - ' + MedicationForm.Name AS MedicationFullName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		Medication.Name LIKE @Name + '%' OR @Name = ''
	ORDER BY
		Medication.Name

END

GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertMedicationFlow]
(
	@MedicationFlowTypeID int,
	@MedicationID int,
	@Count int,
	@Date smalldatetime,
	@Note nvarchar(50)
)
AS
BEGIN
	
	INSERT INTO MedicationFlow
	(
		MedicationFlowTypeID,
		MedicationID,
		[Count],
		[Date],
		Note
	)
	VALUES
	(
		@MedicationFlowTypeID,
		@MedicationID,
		@Count,
		@Date,
		@Note
	)

	exec dbo.sp_UpdateMedicationCountInStock @MedicationID

END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateMedicationFlow]
(
	@MedicationFlowID int,
	@MedicationFlowTypeID int,
	@MedicationID int,
	@Count int,
	@Date smalldatetime,
	@Note nvarchar(50)
)
AS
BEGIN
	
	DECLARE @PrevMedicationID  int

	SELECT
		@PrevMedicationID = MedicationID
	FROM
		MedicationFlow
	WHERE
		MedicationFlowID = @MedicationFlowID

	UPDATE
		MedicationFlow
	SET
		MedicationFlowTypeID = @MedicationFlowTypeID,
		MedicationID = @MedicationID,
		[Count] = @Count,
		[Date] = @Date,
		Note = @Note
	WHERE
		MedicationFlowID = @MedicationFlowID

	IF @PrevMedicationID <> @MedicationID
	 BEGIN
		exec dbo.sp_UpdateMedicationCountInStock @PrevMedicationID
	 END

	exec dbo.sp_UpdateMedicationCountInStock @MedicationID

END
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateMedicationCountInStock]
(
	@MedicationID int
)
AS
BEGIN
	
	DECLARE @CountInStock int,
		@CountGave int

	SET @CountGave = 0
	SET @CountInStock = 0

	SELECT
		@CountInStock = ISNULL(SUM(Count), 0)
	FROM
		MedicationFlow
	WHERE
		MedicationID = @MedicationID
		AND
		MedicationFlowTypeID = 1

	SELECT
		@CountGave = ISNULL(SUM(Count), 0)
	FROM
		MedicationFlow
	WHERE
		MedicationID = @MedicationID
		AND
		MedicationFlowTypeID = 2

	SET @CountInStock = @CountInStock - @CountGave

	UPDATE
		Medication
	SET
		CountInStock = @CountInStock
	WHERE
		MedicationID = @MedicationID

END
GO



USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertMedicationFlow]    Script Date: 2/17/2015 10:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_InsertMedicationFlow]
(
	@MedicationFlowTypeID int,
	@MedicationID int,
	@Count int,
	@Date smalldatetime,
	@Note nvarchar(50)
)
AS
BEGIN
	
	INSERT INTO MedicationFlow
	(
		MedicationFlowTypeID,
		MedicationID,
		[Count],
		[Date],
		Note
	)
	VALUES
	(
		@MedicationFlowTypeID,
		@MedicationID,
		@Count,
		@Date,
		@Note
	)

	exec dbo.sp_UpdateMedicationCountInStock @MedicationID

END

GO


USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMedicationFlow]    Script Date: 2/17/2015 10:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_UpdateMedicationFlow]
(
	@MedicationFlowID int,
	@MedicationFlowTypeID int,
	@MedicationID int,
	@Count int,
	@Date smalldatetime,
	@Note nvarchar(50)
)
AS
BEGIN
	
	DECLARE @PrevMedicationID  int

	SELECT
		@PrevMedicationID = MedicationID
	FROM
		MedicationFlow
	WHERE
		MedicationFlowID = @MedicationFlowID

	UPDATE
		MedicationFlow
	SET
		MedicationFlowTypeID = @MedicationFlowTypeID,
		MedicationID = @MedicationID,
		[Count] = @Count,
		[Date] = @Date,
		Note = @Note
	WHERE
		MedicationFlowID = @MedicationFlowID

	IF @PrevMedicationID <> @MedicationID
	 BEGIN
		exec dbo.sp_UpdateMedicationCountInStock @PrevMedicationID
	 END

	exec dbo.sp_UpdateMedicationCountInStock @MedicationID

END

GO



USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMedicationCountInStock]    Script Date: 2/17/2015 10:48:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_UpdateMedicationCountInStock]
(
	@MedicationID int
)
AS
BEGIN
	
	DECLARE @CountInStock int,
		@CountGave int

	SET @CountGave = 0
	SET @CountInStock = 0

	SELECT
		@CountInStock = ISNULL(SUM(Count), 0)
	FROM
		MedicationFlow
	WHERE
		MedicationID = @MedicationID
		AND
		MedicationFlowTypeID = 1

	SELECT
		@CountGave = ISNULL(SUM(Count), 0)
	FROM
		MedicationFlow
	WHERE
		MedicationID = @MedicationID
		AND
		MedicationFlowTypeID = 2

	SET @CountInStock = @CountInStock - @CountGave

	UPDATE
		Medication
	SET
		CountInStock = @CountInStock
	WHERE
		MedicationID = @MedicationID

END


GO



USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMedication]    Script Date: 2/17/2015 11:12:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SelectMedication]
(
	@MedicationID int
)
AS
BEGIN
	
	SELECT
		Medication.*,
		Medication.Name + ' - ' + MedicationForm.Name AS MedicationFullName
	FROM
		Medication
	INNER JOIN
        MedicationForm ON Medication.MedicationFormID = MedicationForm.MedicationFormID
	WHERE
		Medication.MedicationID = @MedicationID

END


GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationFlowListByMedicationIDWithOffset]
(
	@MedicationID int,
	@Offset int,
	@CountRows int
)
AS
BEGIN
	
	SELECT
	MedicationFlow.*,
	MedicationFlowType.Name AS MedicationFlowTypeName,
	'Видалити' AS DeleteColumn
	FROM
		MedicationFlow
	INNER JOIN
        MedicationFlowType ON MedicationFlow.MedicationFlowTypeID = MedicationFlowType.MedicationFlowTypeID
	WHERE
		MedicationFlow.MedicationID = @MedicationID
	ORDER BY
		MedicationFlow.Date DESC
	OFFSET @Offset ROWS
	FETCH NEXT @CountRows ROWS ONLY

END
GO





SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectMedicationFlowCountByMedicationID]
(
	@MedicationID int
)
AS
BEGIN
	
	DECLARE @MedicationFlowCount int

	SET @MedicationFlowCount = 0

	SELECT
		@MedicationFlowCount = Count(MedicationID)
	FROM
		MedicationFlow
	WHERE
		MedicationID = @MedicationID

	RETURN @MedicationFlowCount

END
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteMedicationFlow] 
(
	@MedicationFlowID int
)
AS
BEGIN
	
	DECLARE @MedicationID  int

	SELECT
		@MedicationID = MedicationID
	FROM
		MedicationFlow
	WHERE
		MedicationFlowID = @MedicationFlowID

	DELETE 
		MedicationFlow
	WHERE
		MedicationFlowID = @MedicationFlowID

	exec dbo.sp_UpdateMedicationCountInStock @MedicationID

END
GO



USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMedicationFlowListByMedicationIDWithOffset]    Script Date: 2/18/2015 12:04:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SelectMedicationFlowListByMedicationIDWithOffset]
(
	@MedicationID int,
	@Offset int,
	@CountRows int
)
AS
BEGIN
	
	SELECT
	MedicationFlow.*,
	MedicationFlowType.Name AS MedicationFlowTypeName,
	'Видалити' AS DeleteColumn
	FROM
		MedicationFlow
	INNER JOIN
        MedicationFlowType ON MedicationFlow.MedicationFlowTypeID = MedicationFlowType.MedicationFlowTypeID
	WHERE
		MedicationFlow.MedicationID = @MedicationID
	ORDER BY
		MedicationFlow.Date DESC
	OFFSET @Offset ROWS
	FETCH NEXT @CountRows ROWS ONLY

END

GO

