CREATE TRIGGER kullaniciYetkiDegistirelemez
ON Kullanicilar
AFTER UPDATE
AS
IF  UPDATE(KullaniciYetki)
/* bir üst satırın yerine şu da olabilir:
 IF COLUMNS_UPDATED() & 4 > 0  */
BEGIN
	IF EXISTS
	(
	SELECT *
	FROM Kullanicilar K JOIN DELETED D
		ON k.KullaniciId=D.KullaniciId
	WHERE D.KullaniciYetki<>K.KullaniciYetki
	)
	BEGIN
		RAISERROR('Kullanıcı yetkisi değiştirilemez',10,1)	
		ROLLBACK
	END
END