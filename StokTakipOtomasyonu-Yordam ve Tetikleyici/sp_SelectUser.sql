USE [StokTakipOtomasyonu]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectUser]    Script Date: 16/12/2018 19:18:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[sp_SelectUser]
As
Begin
Select KullaniciAdi, KullaniciSifre, KullaniciYetki From Kullanicilar
End