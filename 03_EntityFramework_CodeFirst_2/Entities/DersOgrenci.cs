using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst_2.Entities
{
    internal class DersOgrenci
    {
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }


        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
