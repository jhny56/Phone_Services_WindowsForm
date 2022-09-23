CREATE PROC Delete_PhoneTable
@phoneID int
AS
	DELETE FROM TB_Phones
	WHERE PhoneID = @phoneID