using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Proveedor
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(75)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Teléfono")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Need to have 10 decimal digits")]
        public string Num_telef { get; set; }
    }
}
