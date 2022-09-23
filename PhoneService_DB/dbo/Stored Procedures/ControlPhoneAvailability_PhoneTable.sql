CREATE PROC ControlPhoneAvailability_PhoneTable
	@phoneavailable int,
	@phonename varchar(50)
AS
	UPDATE TB_Phones
	SET 
	PhonesAvailable = @phoneavailable - 1
	WHERE PhoneName= @phonename