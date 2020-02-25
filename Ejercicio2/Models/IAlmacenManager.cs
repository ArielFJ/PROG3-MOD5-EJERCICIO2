using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{

    public enum TipoEntidad
    {
        Producto,
        Proveedor
    }

    interface IAlmacenManager
    {
        void AgregarEntidad(IEntidad p);
        void ActualizarEntidad(int id, IEntidad nuevosDatos);
        void EliminarEntidad(int id, TipoEntidad tipo);
    }
}
