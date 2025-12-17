using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst_2.Entities
{
    internal class Sinif
    {
        public int Id { get; set; }
        public string Sube { get; set; }

        //Mapping
        public List<Ogrenci> Ogrencis { get; set; }//Bir sınıfta birden fazla öğrenci olur.
    }
}
