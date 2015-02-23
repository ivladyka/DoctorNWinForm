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