USE [StokTakipOtomasyonu]
GO
/****** Object:  Table [dbo].[Ilceler]    Script Date: 16/12/2018 21:51:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilceler](
	[İlceId] [int] IDENTITY(1,1) NOT NULL,
	[SehirId] [int] NOT NULL,
	[IlceAdi] [char](25) NOT NULL,
 CONSTRAINT [PK_Ilceler] PRIMARY KEY CLUSTERED 
(
	[İlceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kargolar]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kargolar](
	[KargoId] [int] NOT NULL,
	[KargoAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kargolar] PRIMARY KEY CLUSTERED 
(
	[KargoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[KategoriId] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kategoriler] PRIMARY KEY CLUSTERED 
(
	[KategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciId] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](20) NOT NULL,
	[KullaniciSifre] [nvarchar](20) NOT NULL,
	[KullaniciYetki] [bit] NOT NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[KullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Markalar]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Markalar](
	[MarkaId] [int] IDENTITY(1,1) NOT NULL,
	[MarkaAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Markalar] PRIMARY KEY CLUSTERED 
(
	[MarkaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriBilgileri]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriBilgileri](
	[M_BilgileriId] [int] IDENTITY(1,1) NOT NULL,
	[SehirId] [int] NOT NULL,
	[İlceId] [int] NOT NULL,
	[Adres] [nvarchar](150) NOT NULL,
	[TelefonNo] [bigint] NOT NULL,
 CONSTRAINT [PK_MusteriBilgileri] PRIMARY KEY CLUSTERED 
(
	[M_BilgileriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdi] [nvarchar](50) NOT NULL,
	[MusteriSoyadi] [nvarchar](50) NOT NULL,
	[MusteriTCKimlik] [bigint] NOT NULL,
	[Cinsiyet] [char](10) NOT NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[MusteriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdi] [nvarchar](50) NOT NULL,
	[PersonelSoyadi] [nvarchar](50) NOT NULL,
	[Cinsiyet] [char](10) NOT NULL,
 CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sehir]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sehir](
	[SehirId] [int] IDENTITY(1,1) NOT NULL,
	[SehirAdi] [char](25) NOT NULL,
 CONSTRAINT [PK_Sehir] PRIMARY KEY CLUSTERED 
(
	[SehirId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparisler]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparisler](
	[SiparisId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriId] [int] NOT NULL,
	[SiparisNumarasi] [bigint] NOT NULL,
	[UrunId] [int] NOT NULL,
	[Adet] [int] NOT NULL,
	[KargoId] [int] NOT NULL,
 CONSTRAINT [PK_Siparisler] PRIMARY KEY CLUSTERED 
(
	[SiparisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun_Kategori]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun_Kategori](
	[kategoriId] [int] NOT NULL,
	[urunId] [int] NOT NULL,
 CONSTRAINT [PK_Urun_Kategori] PRIMARY KEY CLUSTERED 
(
	[kategoriId] ASC,
	[urunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](50) NOT NULL,
	[ModelAdi] [nvarchar](50) NULL,
	[MarkaId] [int] NOT NULL,
	[StokAdeti] [int] NOT NULL,
	[UrunKodu] [nvarchar](50) NULL,
	[KategoriId] [int] NOT NULL,
	[AlisFiyati] [float] NOT NULL,
	[SatisFiyati] [float] NOT NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Kargolar] ([KargoId], [KargoAdi]) VALUES (1, N'Aras Kargo')
INSERT [dbo].[Kargolar] ([KargoId], [KargoAdi]) VALUES (2, N'Yurtiçi Kargo')
SET IDENTITY_INSERT [dbo].[Kategoriler] ON 

INSERT [dbo].[Kategoriler] ([KategoriId], [KategoriAdi]) VALUES (1, N'Telekomünikasyon')
INSERT [dbo].[Kategoriler] ([KategoriId], [KategoriAdi]) VALUES (2, N'Bilgisayar')
INSERT [dbo].[Kategoriler] ([KategoriId], [KategoriAdi]) VALUES (3, N'Depolama Aygıtları')
INSERT [dbo].[Kategoriler] ([KategoriId], [KategoriAdi]) VALUES (4, N'Televizyon')
SET IDENTITY_INSERT [dbo].[Kategoriler] OFF
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 

INSERT [dbo].[Kullanicilar] ([KullaniciId], [KullaniciAdi], [KullaniciSifre], [KullaniciYetki]) VALUES (1, N'eray', N'123', 1)
INSERT [dbo].[Kullanicilar] ([KullaniciId], [KullaniciAdi], [KullaniciSifre], [KullaniciYetki]) VALUES (4, N'Ela', N'Alganatay', 1)
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
SET IDENTITY_INSERT [dbo].[Markalar] ON 

INSERT [dbo].[Markalar] ([MarkaId], [MarkaAdi]) VALUES (1, N'Samsung')
INSERT [dbo].[Markalar] ([MarkaId], [MarkaAdi]) VALUES (2, N'IPhone')
INSERT [dbo].[Markalar] ([MarkaId], [MarkaAdi]) VALUES (3, N'Asus')
INSERT [dbo].[Markalar] ([MarkaId], [MarkaAdi]) VALUES (4, N'Dell')
INSERT [dbo].[Markalar] ([MarkaId], [MarkaAdi]) VALUES (5, N'MacBook')
INSERT [dbo].[Markalar] ([MarkaId], [MarkaAdi]) VALUES (6, N'Toshiba')
INSERT [dbo].[Markalar] ([MarkaId], [MarkaAdi]) VALUES (7, N'Lenovo')
INSERT [dbo].[Markalar] ([MarkaId], [MarkaAdi]) VALUES (1002, N'Xiaomi')
SET IDENTITY_INSERT [dbo].[Markalar] OFF
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([MusteriId], [MusteriAdi], [MusteriSoyadi], [MusteriTCKimlik], [Cinsiyet]) VALUES (1, N'Eray', N'Özbek', 11111111111, N'Erkek     ')
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
SET IDENTITY_INSERT [dbo].[Siparisler] ON 

INSERT [dbo].[Siparisler] ([SiparisId], [MusteriId], [SiparisNumarasi], [UrunId], [Adet], [KargoId]) VALUES (1, 1, 34321, 2005, 1, 1)
SET IDENTITY_INSERT [dbo].[Siparisler] OFF
INSERT [dbo].[Urun_Kategori] ([kategoriId], [urunId]) VALUES (1, 2005)
INSERT [dbo].[Urun_Kategori] ([kategoriId], [urunId]) VALUES (1, 2008)
INSERT [dbo].[Urun_Kategori] ([kategoriId], [urunId]) VALUES (1, 2009)
INSERT [dbo].[Urun_Kategori] ([kategoriId], [urunId]) VALUES (2, 2006)
INSERT [dbo].[Urun_Kategori] ([kategoriId], [urunId]) VALUES (2, 2007)
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([UrunId], [UrunAdi], [ModelAdi], [MarkaId], [StokAdeti], [UrunKodu], [KategoriId], [AlisFiyati], [SatisFiyati]) VALUES (2005, N'Samsung S8 Edge', N'Galaxy S', 1, 500, N'0101658998', 1, 3400, 4100)
INSERT [dbo].[Urunler] ([UrunId], [UrunAdi], [ModelAdi], [MarkaId], [StokAdeti], [UrunKodu], [KategoriId], [AlisFiyati], [SatisFiyati]) VALUES (2006, N'Asus Zenbook UX390  8GB RAM', N'Zenbook', 3, 800, N'0105459687', 2, 4700, 5800)
INSERT [dbo].[Urunler] ([UrunId], [UrunAdi], [ModelAdi], [MarkaId], [StokAdeti], [UrunKodu], [KategoriId], [AlisFiyati], [SatisFiyati]) VALUES (2007, N'Dell XPS 13 16GB RAM', N'XPS', 4, 900, N'0105789632', 2, 7600, 8359)
INSERT [dbo].[Urunler] ([UrunId], [UrunAdi], [ModelAdi], [MarkaId], [StokAdeti], [UrunKodu], [KategoriId], [AlisFiyati], [SatisFiyati]) VALUES (2008, N'IPhone 8 Plus 64GB', N'Iphone 8', 2, 700, N'0101789635', 1, 4720, 5199)
INSERT [dbo].[Urunler] ([UrunId], [UrunAdi], [ModelAdi], [MarkaId], [StokAdeti], [UrunKodu], [KategoriId], [AlisFiyati], [SatisFiyati]) VALUES (2009, N'IPhone X 64GB', N'Iphone X', 2, 600, N'0101789634', 1, 4900, 5899)
INSERT [dbo].[Urunler] ([UrunId], [UrunAdi], [ModelAdi], [MarkaId], [StokAdeti], [UrunKodu], [KategoriId], [AlisFiyati], [SatisFiyati]) VALUES (15009, N'Deneme', N'adslşöads', 1, 12, N'şsdlaöd', 1, 42, 54)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
ALTER TABLE [dbo].[MusteriBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_MusteriBilgileri_Ilceler] FOREIGN KEY([İlceId])
REFERENCES [dbo].[Ilceler] ([İlceId])
GO
ALTER TABLE [dbo].[MusteriBilgileri] CHECK CONSTRAINT [FK_MusteriBilgileri_Ilceler]
GO
ALTER TABLE [dbo].[MusteriBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_MusteriBilgileri_Sehir] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehir] ([SehirId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MusteriBilgileri] CHECK CONSTRAINT [FK_MusteriBilgileri_Sehir]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Kargolar] FOREIGN KEY([KargoId])
REFERENCES [dbo].[Kargolar] ([KargoId])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Kargolar]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Musteriler] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[Musteriler] ([MusteriId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Musteriler]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([UrunId])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Urunler]
GO
ALTER TABLE [dbo].[Urun_Kategori]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Kategori_Kategoriler] FOREIGN KEY([kategoriId])
REFERENCES [dbo].[Kategoriler] ([KategoriId])
GO
ALTER TABLE [dbo].[Urun_Kategori] CHECK CONSTRAINT [FK_Urun_Kategori_Kategoriler]
GO
ALTER TABLE [dbo].[Urun_Kategori]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Kategori_Urunler] FOREIGN KEY([urunId])
REFERENCES [dbo].[Urunler] ([UrunId])
GO
ALTER TABLE [dbo].[Urun_Kategori] CHECK CONSTRAINT [FK_Urun_Kategori_Urunler]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Markalar] FOREIGN KEY([MarkaId])
REFERENCES [dbo].[Markalar] ([MarkaId])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Markalar]
GO
/****** Object:  StoredProcedure [dbo].[sp_bugunkuSiparisler]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_bugunkuSiparisler]
AS
SELECT M.MusteriAdi + ' ' + M.MusteriSoyadi , M.MusteriTCKimlik, S.*
FROM Siparisler S JOIN  Musteriler M  
ON M.MusteriId=S.MusteriId
/*WHERE siparisTarih < GETDATE()-1 
AND siparisTarih > GETDATE()+1*/
WHERE GETDATE() is NOT NULL
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteMusteri]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_DeleteMusteri]
(
  @MusteriId int
)
As
Begin
	Delete FROM Musteriler Where MusteriId = @MusteriId
End
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteUser]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_DeleteUser]
(
  @KullaniciId int
)
As
Begin
	Delete FROM Kullanicilar Where KullaniciId = @KullaniciId
End
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertMusteriler]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_InsertMusteriler]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUser]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_InsertUser] 
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
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMusteriler]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_SelectMusteriler]
As
Begin 
	Select * From Musteriler
End
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectUser]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_SelectUser]
As
Begin
Select KullaniciAdi, KullaniciSifre, KullaniciYetki From Kullanicilar
End
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMusteri]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_UpdateMusteri]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUser]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_UpdateUser]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_yetkilendir]    Script Date: 16/12/2018 21:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_yetkilendir] (
@KullaniciAdi nvarchar(20),
@KullaniciSifre nvarchar(20),
@KullaniciYetki bit
)

AS
BEGIN
	DECLARE @KullaniciId INT
	IF @KullaniciAdi  IS NULL OR @KullaniciSifre IS NULL
		RETURN 0
	SELECT @KullaniciId=KullaniciId,
 		@KullaniciYetki=KullaniciYetki,
 		@KullaniciAdi=KullaniciAdi
	FROM Kullanicilar
	WHERE KullaniciAdi=@KullaniciAdi AND @KullaniciSifre=@KullaniciSifre 
END
		RETURN 0;
GO
