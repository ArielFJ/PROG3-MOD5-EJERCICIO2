using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class AlmacenManager 
    { 
        private AlmacenManager() { }

        public static readonly AlmacenManager Instance = new AlmacenManager();

        public List<Producto> Productos { get; } = new List<Producto>() { 
            new Producto{Id=1, Nombre="Aceite", FechaVencimiento = DateTime.Parse("12,12,12"), Descripcion="Nada", IdProveedor = 1}
        };
        public List<Proveedor> Proveedores { get; } = new List<Proveedor>() { 
            new Proveedor { Id = 1, Nombre="Grupo Ramos", Direccion="Allí mismo", Num_telef="8298988989"}
        };

        public void ActualizarProducto(int id, Producto p)
        {
            Productos.FirstOrDefault(p => p.Id == id).Nombre = p.Nombre;
            Productos.FirstOrDefault(p => p.Id == id).Descripcion = p.Descripcion;
            Productos.FirstOrDefault(p => p.Id == id).FechaVencimiento = p.FechaVencimiento;
            Productos.FirstOrDefault(p => p.Id == id).IdProveedor = p.IdProveedor;
        }

        public void ActualizarProveedor(int id, Proveedor p)
        {         
            Proveedores.FirstOrDefault(p => p.Id == id).Nombre = p.Nombre;
            Proveedores.FirstOrDefault(p => p.Id == id).Direccion= p.Direccion;
            Proveedores.FirstOrDefault(p => p.Id == id).Num_telef= p.Num_telef;        
        }

        public void AgregarProducto(Producto p)
        {
            p.Id = Productos.Max(c => c.Id) + 1;
            Productos.Add(p);
        }

        public void AgregarProveedor(Proveedor p)
        {
            Proveedores.Add(p);
        }

        public void EliminarProducto(int id)
        {
            Productos.Remove(ObtenerProducto(id));
        }

        public void EliminarProveedor(int id)
        {
            Proveedores.Remove(ObtenerProveedor(id));
        }

        public Proveedor ObtenerProveedor(int id)
        {
            return Proveedores.FirstOrDefault(p => p.Id == id);
        }

        public Producto ObtenerProducto(int id)
        {
            return Productos.FirstOrDefault(p => p.Id == id);
        }

    }
}
