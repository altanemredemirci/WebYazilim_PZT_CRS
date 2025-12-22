using _03_EntityFramework_CodeFirst_2.Context;
using _03_EntityFramework_CodeFirst_2.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03_EntityFramework_CodeFirst_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext();

            //*****Bir Sınıf Kaydı Oluşturduk
            //Sinif sinif = new Sinif();
            //sinif.Sube = "11-F";

            //db.Siniflar.Add(sinif);
            //db.SaveChanges();


            //Sinif sinif = new Sinif();
            //sinif.Sube = "10-A";

            //db.Siniflar.Add(sinif);
            //db.SaveChanges();



            //*****1-1 ilişkili Ogrenci-TC  ve 1-N ilişkili Ogrenci-Sınıf kaydı oluşturuldu
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Ad = "Altan Emre";
            //ogrenci.Soyad = "Demirci";
            //ogrenci.SinifId = 1;
            //ogrenci.TC = new TC() { Numara = "11111111" };


            //db.Ogrenciler.Add(ogrenci);
            //db.SaveChanges();


            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Ad = "Kıvanç";
            //ogrenci.Soyad = "Demirci";
            //ogrenci.SinifId = 2;
            //ogrenci.TC = new TC() { Numara = "11111112" };


            //db.Ogrenciler.Add(ogrenci);
            //db.SaveChanges();


            //Ders ders = new Ders();
            //ders.Ad = "Matematik";

            //Ders ders2 = new Ders();
            //ders2.Ad = "Fen";

            //db.Dersler.Add(ders);
            //db.Dersler.Add(ders2);
            //db.SaveChanges();


            var dersler = db.DersOgrenciler
                .Include(i=> i.Ders)
                .Include(i=> i.Ogrenci)
                .ThenInclude(i=> i.TC)
                .Where(i => i.OgrenciId == 1).ToList();

            
        }
    }
}
