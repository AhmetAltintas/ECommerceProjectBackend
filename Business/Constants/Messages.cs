using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameİnvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameIsAlreadyExists = "Aynı isme sahip başka ürün mevcut.";
        public static string CategoryCountIsFull = "Kategori sayısı dolu olduğu için ürün eklenemez.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductImageAdded = "Ürün görseli eklendi.";
        public static string ProductImageDoesNotFound = "Ürün görseli bulunamadı.";
        public static string ProductImageDeleted = "Ürün görseli silindi.";
        public static string ProductImageUpdated = "Ürün görseli güncellendi.";
        public static string CarImageLimitExceeded = "Ürün görsel limiti dolu.(5)";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string FirstAndLastNameUpdated = "Ad soyad bilgileri güncellendi";
        public static string EmailUpdated = "E-posta bilgisi güncellendi";
        public static string EmailIsAlreadyRegistered = "E-posta adresi zaten kayıtlı.";
        public static string PasswordIsIncorrect = "Parola hatalı.";
        public static string PasswordUpdated = "Parola güncellendi.";
        public static string PasswordsDoNotMatch = "Parolalar aynı değil.";
    }
}
