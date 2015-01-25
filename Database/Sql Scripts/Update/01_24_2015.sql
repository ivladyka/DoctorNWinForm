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
ALTER TABLE dbo.Patient ADD
	Education nvarchar(50) NULL,
	WorkPosition nvarchar(50) NULL,
	Phone nvarchar(50) NULL,
	FinancialNotes nvarchar(MAX) NULL
GO
ALTER TABLE dbo.Patient SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


/****** Object:  StoredProcedure [dbo].[sp_InsertPatient]    Script Date: 1/24/2015 3:55:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_InsertPatient]
(
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50),
	@Birthday smalldatetime,
	@Notes nvarchar(max),
	@Education nvarchar(50),
	@WorkPosition nvarchar(50),
	@Phone nvarchar(50),
	@FinancialNotes nvarchar(max)
)
AS
BEGIN

	DECLARE @PatientID int

	INSERT INTO [dbo].[Patient]
           ([FirstName]
           ,[LastName]
           ,[MiddleName]
           ,[Birthday]
           ,[Notes]
		   ,Education
		   ,WorkPosition
		   ,Phone
		   ,FinancialNotes)
     VALUES
           (@FirstName
           ,@LastName
           ,@MiddleName
           ,@Birthday
           ,@Notes
		   ,@Education
		   ,@WorkPosition
		   ,@Phone
		   ,@FinancialNotes)

	SET @PatientID = (SELECT @@Identity)
	RETURN ISNULL(@PatientID, 0)
END



GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePatient]    Script Date: 1/24/2015 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_UpdatePatient]
(
	@PatientID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50),
	@Birthday smalldatetime,
	@Notes nvarchar(max),
	@Education nvarchar(50),
	@WorkPosition nvarchar(50),
	@Phone nvarchar(50),
	@FinancialNotes nvarchar(max)
)
AS
BEGIN
	
	UPDATE [dbo].[Patient]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[MiddleName] = @MiddleName
      ,[Birthday] = @Birthday
      ,[Notes] = @Notes
	  ,Education = @Education
	  ,WorkPosition = @WorkPosition
	  ,Phone = @Phone
	  ,FinancialNotes = @FinancialNotes
	WHERE 
		PatientID = @PatientID

END


/****** Object:  StoredProcedure [dbo].[sp_SelectVisitList]    Script Date: 1/24/2015 5:41:58 PM ******/
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


INSERT INTO [dbo].[MedicalTestType]
           ([Name])
     VALUES
           ('Анамнез')
GO

INSERT INTO [dbo].[MedicalTestType]
           ([Name])
     VALUES
           ('Призначення')
GO



/****** Object:  StoredProcedure [dbo].[sp_SelectMedicalTestList]    Script Date: 1/25/2015 10:36:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SelectMedicalTestList]
(
	@VisitID int
)
AS
BEGIN
	
	SELECT        
		MedicalTest.MedicalTestID, 
		MedicalTest.MedicalTestTypeID, 
		MedicalTest.FileName, 
		MedicalTest.Date,
		MedicalTestType.Name AS MedicalTestTypeName,
		'Видалити' AS DeleteColumn,
		'Проглянути' AS ViewColumn
	FROM            
		MedicalTest 
	INNER JOIN
		MedicalTestType ON MedicalTest.MedicalTestTypeID = MedicalTestType.MedicalTestTypeID
	WHERE
		MedicalTest.VisitID = @VisitID
	ORDER BY
		MedicalTest.Date DESC

END
