CREATE PROC sp_yetkilendir (
@KullaniciAdi nvarchar(20),
@KullaniciSifre nvarchar(20),
@KullaniciYetki bit
)

AS
BEGIN
	DECLARE @KullaniciId INT
	IF @KullaniciAdi  IS NULL OR @KullaniciSifre IS NULL
		RETURN 0
	SELECT @KullaniciId=KullaniciId,
 		@KullaniciYetki=KullaniciYetki,
 		@KullaniciAdi=KullaniciAdi
	FROM Kullanicilar
	WHERE KullaniciAdi=@KullaniciAdi AND @KullaniciSifre=@KullaniciSifre 
END
		RETURN 0;