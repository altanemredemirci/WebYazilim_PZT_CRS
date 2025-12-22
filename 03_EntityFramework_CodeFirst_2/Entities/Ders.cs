using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst_2.Entities
{
    internal class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        //ManyToMany
        //Bir dersi birden fazla öğrenci alabilir.
        public List<Ogrenci> Ogrencis { get; set; }
    }
}
