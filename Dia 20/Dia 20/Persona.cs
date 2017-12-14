using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dia_20
{
    public class Persona { 
    
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

    [Required]
    [StringLength(50)]
    public string Surname { get; set; }

        [Required]
        public int Age { get; set; }
    }
}