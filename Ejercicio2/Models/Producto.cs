using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Producto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(125)]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaVencimiento { get; set; }
    
        [Required]
        public int IdProveedor { get; set; }
    }
}
