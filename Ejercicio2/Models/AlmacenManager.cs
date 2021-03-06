﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class AlmacenManager 
    { 
        private AlmacenManager() { }

        public static readonly AlmacenManager Instance = new AlmacenManager();

        public List<Producto> Productos { get; } = new List<Producto>();
        public List<Proveedor> Proveedores { get; } = new List<Proveedor>();

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
            var id = Productos.Count > 0 ? Productos.Max(s => s.Id) + 1 : 0;
            p.Id = id;
            Productos.Add(p);
        }

        public void AgregarProveedor(Proveedor p)
        {
            var id = Proveedores.Count > 0 ? Proveedores.Max(s => s.Id) + 1 : 0;
            p.Id = id;
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

        public bool TieneDependenciasConProductos(int id)
        {
            foreach (var item in Productos)
                if (item.IdProveedor == id)
                    return true;
            return false;
        }

    }
}
