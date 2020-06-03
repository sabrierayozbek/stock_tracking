Create Proc sp_DeleteMusteri
(
  @MusteriId int
)
As
Begin
	Delete FROM Musteriler Where MusteriId = @MusteriId
End