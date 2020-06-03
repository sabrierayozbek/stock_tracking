[![GitHub issues](https://img.shields.io/github/issues/sabrierayozbek/stock_tracking.svg)](https://github.com/sentiment_and_personality_analysis/issues)
[![GitHub forks](https://img.shields.io/github/forks/sabrierayozbek/stock_tracking.svg)](https://github.com/sentiment_and_personality_analysis/network)


# Stock Tracking Program With All DB Actions
 It is a desktop program that I designed to do extended work on databases. In this project, you can find all database related actions.

## Introduction: 

Inventory tracking is the amount of products obtained by procuring or producing, which are kept for a certain period of time before being used or supplied to the customer. The stock tracking program i have created; offers you stock and product tracking, customer information, personnel information, contracted cargo, stock control integrated with order control.


## Content: 

- Entrance panel that will meet the user within the project.
- If a successful login has been made, the user can now see the main window.
lists)
- Add - Delete and Update Stock
- Product Add-Delete and Product Update
- Add-Delete and Update Orders
- Update and Delete Customer Information / Add Customer
- Staff information
- Cargo information
- Member Creation Screen


## Use Case Diagram: 

![stock_tracking use-case](https://github.com/sabrierayozbek/stock_tracking/blob/master/images/use-case.png)

## Relational Schema: 

![stock_tracking re_schema](https://github.com/sabrierayozbek/stock_tracking/blob/master/images/re_schema.png)

- Kullanicilar (KullaniciId:int, KullaniciAdi: nvarchar(20), KullaniciSifre: nvarchar(20), KullaniciYetki bit)
- Personeller (PersonelId:int, PersonelAdi: nvarchar(50), PersonelSoyadi: nvarchar(50), Cinsiyet char(10))
- Urun_Kategori (UrunId:int, KategoriId:int)
- Markalar (MarkaId:int MarkaAdi: nvarchar(50))
- MusteriBilgileri (M_BilgileriId:int, SehirId: int, IlceId: int, TelefonNo:varchar(50))
- Sehir (Sehir_Id:int, SehirAdi:nvarchar(50))
- Ilceler (IlceId:int, SehirId:int IlceAdi:varchar(50))
- Siparisler (SiparisId:int,MusteriId: int, SiparisNumararis: nvarchar(50), UrunId: int, Adet:int, KargoId:int))
- Kargolar (KargoId:int,KargoAdi: nvarchar(50))
- Musteriler (MusteriId: int,MusteriAdi: nvarchar(50), MusteriSoyadi: nvarchar(50),
- MusteriTCKimlik:nvarcharr(50), Cinsiyet char(10))


## Business Rules: 

- Customers can order.
- Order data has categories of products.
- While a product can belong to one or more categories, one category can fall into more than one category.
- Communication and identity information of the customers are kept. Orders given are sent according to this information.
- Orders are shipped with shipping information.
- There are users and staff, only information is kept.

## General DB

![stock_tracking VB](https://github.com/sabrierayozbek/stock_tracking/blob/master/images/VB.png)

