using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string CarsListed = "Arabalar Listelendi";
        public static string CarCheckImageLimited = "Bir arabanın maksimum 5 resmi olabilir";
        public static string CarImagesListed = "Araba resimleri listelendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string ColorsListed = "Renkler listelendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string CarAlreadyRented = "Araba bu tarihte zaten kiralanmış";
        public static string CarRented = "Araba kiralandı";
        public static string PaymentSuccessful = "Ödeme işlemi tamamlandı";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string CarUpdated = "Araba Güncellendi";
        
    }
}
