using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static sürekli new kullanmamak için var. Tek bir instance
    //public yapılar büyük yazılır pascal keys
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalıd = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Ürün İsmi Sisteme Kayıtlı";
        public static string CategoriesListed = "Kategoriler Listelendi";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldığı İçin Yeni Ürün Eklenemiyor";
    }
}
