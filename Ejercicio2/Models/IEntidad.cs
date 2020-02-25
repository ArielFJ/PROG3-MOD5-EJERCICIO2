using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public interface IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
