using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst_2.Entities
{
    internal class TC
    {
        public int Id { get; set; }
        public string Numara { get; set; }

        //OneToOne 1-1
        //Her TC bir öğrenciye aittir.
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; } //yazılan OgrenciId değerinin gerçekten kayıtlı bir Id olup olmadığı kontrol etmek.
    }
}
