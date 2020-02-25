using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class AlmacenManager : IAlmacenManager
    {
        private AlmacenManager()
        {

        }

        private static AlmacenManager instance = new AlmacenManager();

        public static AlmacenManager Instance { 
            get
            {
                return instance;
            }
        }

        public List<Producto> Productos { get; } = new List<Producto>() { 
            new Producto{Id=1, Nombre="Aceite", FechaVencimiento = DateTime.Parse("12,12,12"), Descripcion="Nada", IdProveedor = 1}
        };
        public List<Proveedor> Proveedores { get; } = new List<Proveedor>() { 
            new Proveedor { Id = 1, Nombre="Grupo Ramos", Direccion="Allí mismo", Num_telef="8298988989"}
        };

        public void ActualizarEntidad(int id, IEntidad nuevosDatos)
        {
            if(nuevosDatos is Producto)
            {
                Producto p = nuevosDatos as Producto;
                Productos.FirstOrDefault(p => p.Id == id).Nombre = p.Nombre;
                Productos.FirstOrDefault(p => p.Id == id).Descripcion = p.Descripcion;
                Productos.FirstOrDefault(p => p.Id == id).FechaVencimiento = p.FechaVencimiento;
                Productos.FirstOrDefault(p => p.Id == id).IdProveedor = p.IdProveedor;                               
            }
            else
            {
                Proveedor p = nuevosDatos as Proveedor;
                Proveedores.FirstOrDefault(p => p.Id == id).Nombre = p.Nombre;
                Proveedores.FirstOrDefault(p => p.Id == id).Direccion= p.Direccion;
                Proveedores.FirstOrDefault(p => p.Id == id).Num_telef= p.Num_telef;
            }
        }

        public void AgregarEntidad(IEntidad p)
        {
            if(p is Producto)
            {
                Productos.Add(p as Producto);
            } 
            else
            {
                Proveedores.Add(p as Proveedor);
            }
        }

        public void EliminarEntidad(int id, TipoEntidad tipo)
        {
            if(tipo == TipoEntidad.Producto)
            {
                Productos.Remove(Productos.FirstOrDefault(p => p.Id == id));
            }
            else
            {
                Proveedores.Remove(Proveedores.FirstOrDefault(p => p.Id == id));
            }
        }

        public Proveedor ObtenerProveedor(int id)
        {
            return Proveedores.FirstOrDefault(p => p.Id == id);
        }

    }
}
