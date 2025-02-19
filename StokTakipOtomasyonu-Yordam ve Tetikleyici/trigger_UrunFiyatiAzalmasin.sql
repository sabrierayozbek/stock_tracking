USE [StokTakipOtomasyonu]
GO
/****** Object:  Trigger [dbo].[urunFiyatiAzalmasin]    Script Date: 16/12/2018 20:29:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[urunFiyatiAzalmasin]
ON [dbo].[Urunler]
AFTER UPDATE
AS
BEGIN
	IF EXISTS
	(
 		SELECT * 
		FROM INSERTED I INNER JOIN DELETED D
			ON D.UrunId=I.UrunId
		WHERE D.SatisFiyati>I.SatisFiyati
	)
	BEGIN
		RAISERROR('Ürün Fiyatları Azaltılamaz',10,1)
		ROLLBACK
	END
END
