CREATE PROC EditAdd_PhoneTable
@phoneID int,
@phonename VARCHAR(50),
@brand VARCHAR(50),
@price int,
@productionyear int,
@phonespecs VARCHAR(50),
@phoneavailable int
AS
	IF @phoneID = 0
	INSERT INTO TB_Phones(PhoneName,Brand,Price,ProductionYear,PhoneSpecs,PhonesAvailable)
	VALUES(@phonename,@brand,@price,@productionyear,@phonespecs,@phoneavailable)
	ELSE
	UPDATE TB_Phones
	SET 
	PhoneName = @phonename,
	Brand = @brand,
	Price = @price,
	ProductionYear = @productionyear,
	PhoneSpecs = @phonespecs,
	PhonesAvailable = @phoneavailable
	WHERE PhoneID = @phoneID