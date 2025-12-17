using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst.Entity
{
    internal class Product
    {
        //Attribute:bir property tanımının üstüne yazılan ve o property'e özellik vermemizi sağlayan yapıdır.

        public int Id { get; set; }
        
        [MaxLength(30)]
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }
    }
}
