Create Proc sp_InsertUser 
(
	@KullaniciAdi nvarchar(20),
	@KullaniciSifre nvarchar(20),
	@KullaniciYetki bit
)
As
Begin
Insert Into Kullanicilar (KullaniciAdi,KullaniciSifre,KullaniciYetki)
Values (@KullaniciAdi,@KullaniciSifre,@KullaniciYetki)
End
