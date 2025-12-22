using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst.Entity
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }
    }
}
