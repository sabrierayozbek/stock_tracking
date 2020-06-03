CREATE TRIGGER [dbo].[bakmadanSiparisSilinmez]
ON [dbo].[Siparisler]
AFTER  DELETE
AS
IF EXISTS
(
	SELECT * 
	FROM Siparisler S JOIN DELETED D 
		ON D.SiparisNumarasi=S.SiparisId
	WHERE S.Adet=0
)
BEGIN
	RAISERROR('Siparişe Bakmadan Silemezsiniz.',10,1)
	ROLLBACK
END