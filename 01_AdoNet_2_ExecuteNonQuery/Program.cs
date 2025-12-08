using System.Data.SqlClient;

namespace _01_AdoNet_2_ExecuteNonQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metotlar iç içe tanımlanamazlar.

            //ExecuteNonQuery(): bu metot Insert,Update,Delete gibi data manipülasyonu olan işlemlerde sql komutunu çalıştırmamızı sağlar.

            //Category.CategoryEkle();


            //Console.WriteLine("Silinecek Id:");
            //int Id = Convert.ToInt32(Console.ReadLine());

            //Category.CategorySil(Id);


            Category cat = new Category();

            Console.WriteLine("Kategori Id:");
            cat.CategoryID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kategori Adı:");
            cat.CategoryName = Console.ReadLine();

            Console.WriteLine("Açıklama:");
            cat.Description = Console.ReadLine();

            Category.CategoryGuncelle(cat);


            //Shippers tablosunda ekleme, silme ve güncelleme işlemlerini ADO.NEt ile yapınız 
        }

      
    }
}
