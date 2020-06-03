Create Trigger markaKayit
on Markalar
After Insert
As
Begin 
	Select 'Yeni bir marka kaydı yapıldı'
End

Insert Into Markalar values ('Xiaomi')