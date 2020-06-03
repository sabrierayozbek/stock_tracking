CREATE VIEW vw_100birimAlti 

AS
SELECT UrunKodu, UrunAdi, SatisFiyati
FROM Urunler 
WHERE SatisFiyati<100
WITH CHECK OPTION