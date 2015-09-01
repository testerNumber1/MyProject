using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.MVC.File.Models
{
    public class Person
    {
        [Required]
        [StringLength(20,MinimumLength =6)]
        public string Name { get; set; }

        public int? Age { get; set; }
    }
}
