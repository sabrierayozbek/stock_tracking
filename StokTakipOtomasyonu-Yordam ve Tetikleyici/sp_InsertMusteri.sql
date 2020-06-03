Create Proc sp_InsertMusteriler
(
	@MusteriAdi nvarchar(50),
	@MusteriSoyadi nvarchar(50),
	@MusteriTCKimlik bigint,
	@Cinsiyet char(10)
)
As
Begin 
	Insert Into Musteriler(MusteriAdi,MusteriSoyadi,MusteriTCKimlik,Cinsiyet)
Values (@MusteriAdi,@MusteriSoyadi,@MusteriTCKimlik,@Cinsiyet)
End