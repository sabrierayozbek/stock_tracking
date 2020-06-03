CREATE PROC sp_bugunkuSiparisler
AS
SELECT M.MusteriAdi + ' ' + M.MusteriSoyadi , M.MusteriTCKimlik, S.*
FROM Siparisler S JOIN  Musteriler M  
ON M.MusteriId=S.MusteriId
/*WHERE siparisTarih < GETDATE()-1 
AND siparisTarih > GETDATE()+1*/
WHERE GETDATE() is NOT NULL