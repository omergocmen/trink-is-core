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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductNameAlreadyExist = "Bu isimde zaten başka bir ürün var";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string ApplicationListed = "Başvurular başarıyla listelendi";
        public static string ApplicationFound = "Başvuru başarıyla bulundu";
        public static string ApplicationAdded = "Başvuru başarıyla eklendi";
        public static string ApplicationDeleted = "Başvuru başarıyla silindi";
        public static string ApplicationUpdated = "Başvuru başarıyla güncellendi";

        public static string CandidatesListed = "Adaylar başarıyla listelendi";
        public static string CandidateFound = "Aday başarıyla bulundu";
        public static string CandidateAdded = "Aday başarıyla eklendi";
        public static string CandidateDeleted = "Aday başarıyla silindi";
        public static string CandidateUpdated = "Aday başarıyla güncellendi";

        public static string EmployersListed = "İş verenler başarıyla listelendi";
        public static string EmployerFound = "İş veren başarıyla bulundu";
        public static string EmployerAdded = "İş veren başarıyla eklendi";
        public static string EmployerDeleted = "İş veren başarıyla silindi";
        public static string EmployerUpdated = "İş veren başarıyla güncellendi";

        public static string JobAnnouncementsListed = "İş ilanları başarıyla listelendi";
        public static string JobAnnouncementsFound = "İş ilanı başarıyla bulundu";
        public static string JobAnnouncementsAdded = "İş ilanı başarıyla eklendi";
        public static string JobAnnouncementDeleted = "İş ilanı başarıyla silindi";
        public static string JobAnnoncementUpdated = "İş ilanı başarıyla güncellendi";

        public static string CategoryListed = "Kategoriler başarıyla listelendi";
        public static string CategoryFound = "Kategori başarıyla bulundu";
        public static string CategoryAdded = "Kategoryi başarıyla eklendi";
        public static string CategoryDeleted = "Kategoryi başarıyla silindi";
        public static string CategoryUpdated = "Kategoryi başarıyla güncellendi";


    }
}
