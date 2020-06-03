Create Proc sp_UpdateMusteri
(
	@MusteriId int,
	@MusteriAdi nvarchar(50),
	@MusteriSoyadi nvarchar(50),
	@MusteriTCKimlik bigint,
	@Cinsiyet char(10)
)
As
Begin
	Update Musteriler
	Set  MusteriAdi = @MusteriAdi, MusteriSoyadi = @MusteriSoyadi, MusteriTCKimlik = @MusteriTCKimlik, Cinsiyet = @Cinsiyet
	Where MusteriId = @MusteriId
End