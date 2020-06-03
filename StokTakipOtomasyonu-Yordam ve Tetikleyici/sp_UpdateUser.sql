Create Proc sp_UpdateUser
(
	@KullaniciId int,
	@KullaniciAdi nvarchar(20),
	@KullaniciSifre nvarchar(20),
	@KullaniciYetki bit
)
As
Begin
	Update Kullanicilar
	Set KullaniciAdi = @KullaniciAdi, @KullaniciSifre = @KullaniciSifre, @KullaniciYetki = @KullaniciYetki
	Where KullaniciId = @KullaniciId
End