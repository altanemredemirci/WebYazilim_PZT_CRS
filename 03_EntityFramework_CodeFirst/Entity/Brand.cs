using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst.Entity
{
    internal class Brand
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //EntityFrameworkCore sayesinde ID,Id,id vb tanımlarda otoamtik olarak PK ve Identity özellikleri atanır.
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
