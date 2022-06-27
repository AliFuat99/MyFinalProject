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
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductsListed = "Ürünler Listelendi";
        internal static string ProductCountOfCategoryError;
    }
}
