using _02_EntityFramework.Entities;
using _02_EntityFramework.Methods;
using Microsoft.EntityFrameworkCore;

namespace _02_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# ile SQL bağlayan yapılara ORM(Object Relation Mapping)
            /*
             ENTITYFRAMEWORK
            - Code First
            - Database First
            - Modal First
            - Code First(Varolan Database)
             

            DATABASE FIRST:Hali hazırda varolan bir database'in C# bağlanması ilgili classların otomatik oluşmasını sağlar.



            SQL Server Authentication
            "Server=202-3\SQLDERS; Database=NORTHWND; Uid=sa; Pwd=1;"

            Windows Authentication
            "Server=202-3\SQLDERS; Database=NORTHWND; TrustServerCertificate=true; Trusted_Connection=true"
            
             
             DATABASE FIRST
            ****************
            Scaffold-DbContext "Server=202-3\SQLDERS;Database=Northwind;Trusted_Connection=True; TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities
             

            Kurulan Paketler
            *Microsoft.EntityFramework 8.0.22
            *Microsoft.EntityFrameworkCore.SqlServer
            *Microsoft.EntityFrameworkCore.Tools
             */

            //NorthwndContext db = new NorthwndContext();

            //List<Category> categories = db.Categories.ToList();


            //Ürünler Listesi
            //var products = Execute.GetProducts();

            //Belirli Bir Kategorideki Ürünler
            //var products = Execute.GetProductsByCategory(1);

            //Ürün ve Kategori Bilgilerini Birleştir
            //Execute.GetCategoriesByProducts();

            //Sipariş Detayları ile Ürün Bilgisi
            //Execute.GetOrderDetails();

            //Kategorilere Göre Ürün Sayısı
            //Execute.GetCategoryProductCount();

            //Kategorilere Göre Ortalama Fiyat
            //Execute.GetCategoryAveragePrice();

            //En Çok Sipariş Edilen Ürünler
            //Execute.TopProductbyOrders();

            //Müşteri ve Siparişleri
            //Execute.CustomerOrders();

            //Ürün Arama
            //Execute.ProductSearch();

            //Çoklu Koşul
            //Execute.FilteredProducts();

            NorthwndContext db = new NorthwndContext();
            #region Germany ülkesindeki müşterilerin adlarını listeleyiniz

            //var customers = db.Customers
            //    .Where(c => c.Country == "Germany").ToList();

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.CompanyName+" "+item.Country);
            //}

            #endregion

            #region Sipariş detayları ile Ürün adlarını listeleyiniz

            //var orders = db.Orders
            //    .Include(o => o.OrderDetails)
            //    .ThenInclude(od => od.Product)
            //    .ThenInclude(p=> p.Category)
            //    .ToList();


            #endregion

            #region Any, All

            //Birim fiyatı 100 lira büyük ürün var mı?
            bool urunVarMi = db.Products.Any(p => p.UnitPrice > 100);


            bool stoklarinHepsiVarmi = db.Products.All(p => p.UnitsInStock > 0);

            #endregion
        }
    }
}
