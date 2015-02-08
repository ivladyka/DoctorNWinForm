﻿/****** Object:  StoredProcedure [dbo].[sp_SelectVisitList]    Script Date: 1/24/2015 5:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_SelectVisitList]
(
	@PatientID int
)
AS
BEGIN
	
	SELECT 
		[VisitID]
      ,[Date]
      ,[Anamnesis]
      ,[Prescription]
	  ,'Видалити' AS DeleteColumn
	FROM 
		[dbo].[Visit]
	WHERE
		PatientID = @PatientID
	ORDER BY
		[Date] DESC

END

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
ALTER TABLE dbo.MedicalTest SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.[Document]
	(
	DocumentID int NOT NULL IDENTITY (1, 1),
	MedicalTestID int NOT NULL,
	FileName nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.[Document] ADD CONSTRAINT
	PK_Document PRIMARY KEY CLUSTERED 
	(
	DocumentID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.[Document] ADD CONSTRAINT
	FK_Document_MedicalTest FOREIGN KEY
	(
	MedicalTestID
	) REFERENCES dbo.MedicalTest
	(
	MedicalTestID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.[Document] SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


INSERT INTO [dbo].[Document]
           ([MedicalTestID]
           ,[FileName])
SELECT 
	MedicalTestID, FileName
       FROM MedicalTest
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
ALTER TABLE dbo.MedicalTest
	DROP COLUMN FileName
GO
ALTER TABLE dbo.MedicalTest SET (LOCK_ESCALATION = TABLE)
GO
COMMIT



/****** Object:  StoredProcedure [dbo].[sp_DeletePatient]    Script Date: 2/7/2015 4:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_DeletePatient]
(
	@PatientID int
)
AS
BEGIN
	
	BEGIN TRANSACTION DeletePatientFullInfo

	DELETE
		Document
	FROM
		Document d 
	INNER JOIN 
		MedicalTest ON d.MedicalTestID = MedicalTest.MedicalTestID
	INNER JOIN 
		Visit ON MedicalTest.VisitID = Visit.VisitID
	WHERE
		Visit.PatientID = @PatientID

	DELETE
		MedicalTest
	FROM
		MedicalTest mt INNER JOIN Visit ON mt.VisitID = Visit.VisitID
	WHERE
		Visit.PatientID = @PatientID

	DELETE
		Visit
	WHERE
		PatientID = @PatientID

	DELETE FROM 
		[dbo].[Patient]
	WHERE
		PatientID = @PatientID

	COMMIT TRANSACTION DeletePatientFullInfo

END


GO



/****** Object:  StoredProcedure [dbo].[sp_DeleteVisit]    Script Date: 2/7/2015 4:53:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_DeleteVisit]
(
	@VisitID int
)
AS
BEGIN
	
	BEGIN TRANSACTION DeleteVisitFullInfo

	DELETE
		Document
	FROM
		Document d INNER JOIN MedicalTest ON d.MedicalTestID = MedicalTest.MedicalTestID
	WHERE
		MedicalTest.VisitID = @VisitID

	DELETE
		MedicalTest
	WHERE
		VisitID = @VisitID

	DELETE
		Visit
	WHERE
		VisitID = @VisitID

	COMMIT TRANSACTION DeleteVisitFullInfo

END


GO


USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteMedicalTest]    Script Date: 2/7/2015 4:57:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_DeleteMedicalTest]
(
	@MedicalTestID int
)
AS
BEGIN
	
	BEGIN TRANSACTION DeleteMedicalTestFullInfo

	DELETE
		Document
	WHERE
		MedicalTestID = @MedicalTestID

	DELETE 
		MedicalTest
	WHERE
		MedicalTestID = @MedicalTestID

	COMMIT TRANSACTION DeleteMedicalTestFullInfo

END


GO


USE [DoctorNWinForm]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertMedicalTest]    Script Date: 2/7/2015 4:59:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_InsertMedicalTest]
(
	@MedicalTestTypeID int,
	@VisitID int,
	@Date smalldatetime
)
AS
BEGIN
	
	DECLARE @MedicalTestID int

	INSERT INTO [dbo].[MedicalTest]
           ([MedicalTestTypeID]
           ,[VisitID]
           ,[Date])
     VALUES
           (@MedicalTestTypeID
           ,@VisitID
           ,@Date)

	SET @MedicalTestID = (SELECT @@Identity)
	RETURN ISNULL(@MedicalTestID, 0)

END


GO


GO
