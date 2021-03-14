using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages // static oldugu zaman newleme gerek kalmaz
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategori limitini aştınız";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün bulunmaktadır";
        public static string CategoryLimitExceded = "Kategori sayısını aştınız";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
