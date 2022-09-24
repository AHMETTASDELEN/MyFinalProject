using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        
        
        //GENERAL
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";

        //PRODUCT
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";

        //CUSTOMER
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        //CATEGORY
        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryDeleted = "Kategori Silindi";
        public static string CategoryUpdated = "Kategori Güncellendi";

    }
}
