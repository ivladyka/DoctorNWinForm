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