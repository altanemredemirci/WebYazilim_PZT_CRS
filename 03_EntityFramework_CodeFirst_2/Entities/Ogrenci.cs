using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst_2.Entities
{
    internal class Ogrenci:Insan
    {
        //OneToMany 1-N
        //Her öğrencinin 1 sınıfı olabilir. Bir sınıfın birden fazla öğrencisi olur.
        
        //Mapping
        public int SinifId { get; set; } //Her öğrenci nesnesinin 1 sınıfId değeri olur.
        public Sinif Sinif { get; set; }


        //OneToOne
        //Her Ogrencinin bir tc numarası olur.
        public int TCId { get; set; }
        public TC TC { get; set; }

    }
}
