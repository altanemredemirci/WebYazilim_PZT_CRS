using _02_EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EntityFramework.Methods
{
    internal class Execute
    {

        public static NorthwndContext db = new NorthwndContext();

        #region Ürünler Listesi

        public static List<Product> GetProducts()
        {
            //LINQtoSQL

            //var products = from p in db.Products
            //               select p;

            //return products.ToList();


            //LINQ
            var products = db.Products.ToList();

            return products;
        }

        #endregion

        #region Belirli Bir Kategorideki Ürünler

        public static List<Product> GetProductsByCategory(int categoryId)
        {
            //LINQtoSQL
            //var products = from p in db.Products
            //               where p.CategoryId == categoryId
            //               select p;

            //return products.ToList();

            //LINQ
            var products = db.Products.Where(p => p.CategoryId == categoryId).ToList();

            return products;
        }




        #endregion

        #region Fiyat 20'den Büyük Ürünler

        public static List<Product> GetProductsByPrice()
        {
            var products = db.Products.Where(i => i.UnitPrice > 20).ToList();

            return products;
        }

        #endregion

        #region Ürün ve Kategori Bilgilerini Birleştir
        public static void GetCategoriesByProducts()
        {
            // select ProductName, CategoryName, UnitPrice from Products p
            // join Categories c on p.CategoryID = c.CategoryID


            var liste = db.Products
                .Join(db.Categories,
                p => p.CategoryId,
                c => c.CategoryId,
                (p, c) => new
                {
                    ProductName = p.ProductName,
                    CategoryName = c.CategoryName,
                    UnitPrice = p.UnitPrice
                })
                .ToList();
        }


        #endregion

        #region Sipariş Detayları ile Ürün Bilgisi
        
        public static void GetOrderDetails()
        {
            var orderDetails = db.OrderDetails
                .Join(db.Products,
                od => od.ProductId,
                p => p.ProductId,
                (od, p) => new
                {
                    OrderID = od.OrderId,
                    ProductName = p.ProductName,
                    Quantity = od.Quantity,
                    UnitPrice = od.UnitPrice,
                    Total = od.Quantity * od.UnitPrice
                })
                .ToList();
        }
        #endregion

        #region Kategorilere Göre Ürün Sayısı

        public static void GetCategoryProductCount()
        {
            var productCountByCateogry = db.Products
                .GroupBy(p => p.Category.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    ProductCount = g.Count()
                })
                .OrderByDescending(x => x.ProductCount)
                .ToList();
        }

        #endregion
    }
}
