using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst_2.Entities
{
    internal class Insan
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Ad { get; set; }
        public string? Soyad { get; set; }
    }
}
