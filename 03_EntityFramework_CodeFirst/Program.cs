namespace _03_EntityFramework_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Product:Id,Name,Price,Stok
             * Category:Id,Name,Description
             * Brand:Id,Name
             
             
         
            */
        }
    }
}
/*
 ******* CODEFIRST *********
 *Code First bir projenin şablonunu C# tarafında(yazılım) oluşturulması ve veritabanı, tablolar,ilişkiler,kısıtlamalar vb özelliklerin yazılım tarafında sürdürülme yöntemidir.
 
 *** Adım Adım Code First ***
 1-EntityFrameworkCore paketini kurulur.
 2-Projede kullanılan entity-object ve aralarındaki ilişkiler, Her entity nin propertlerinin atrributeleri tanımlanır.(Entity Klasör veya Entity proje katmanı)
3-ProjectContext.cs classını açıyoruz.Bu sınıf bizim SQL bağlantımızı ve SQL yapımızı tanımlayacağımız sınıftır.
4-EntityFrameworkCore.SqlServer ve Microsoft.EntityFrameworkCore.Design paketlerini kuruyoruz.
5-DbContext yapısını ProjectContext'e miras alıyoruz.
6-DbContext classı sayesinde veritabanı bağlantısı yazılır ve tablo olmasını istediğimiz entityleri DbSet<> komutu ile set ediyoruz.
    6.1-DatabaseConnectionString yazmanın 3 farklı yöntemi vardır.
        6.1.1-DbContext.cs miraas alan class içerisinde OnConfiguring() metodunu override ederek UsqSqlServer() metoduna parametre olarak bağlantı cümlesini yazmak.
        6.1.2-Program.cs altıdna bir servis tanımlayarak yine UseSqlServer() metoduna parametre olarak bağlantı cümlesini yazmak.
        6.1.3-appsettings.json dosyası altında ConnectionString etiketinde key,value olarak tanımlamak.
        **UseSqlServer() EntityFrameworkCore.SqlServer paket kurumuluyla gelir.
7-Tools->Nuget Package Manager->Package Manager Console açıyoruz.
    7.1 Add-Migration 
    7.2 Update-Database 
 */