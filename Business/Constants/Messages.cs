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
    }
}
