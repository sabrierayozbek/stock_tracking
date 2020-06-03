Create Proc sp_DeleteUser
(
  @KullaniciId int
)
As
Begin
	Delete FROM Kullanicilar Where KullaniciId = @KullaniciId
End