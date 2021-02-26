using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //newlememek için static
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";

        public static string ProductCountOfError = "Ürünler sayısı aşıldı.";

        public static string ProductNameExists = "Aynı ürün adından zaten var.";

        public static string CategoryLimitExceded = "Kategori limiti aşıldı.";
    }
}
