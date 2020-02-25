using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio2.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: /<controller>/
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                AlmacenManager.Instance.AgregarProveedor(proveedor);
                return RedirectToAction("List");
            }
            return View(proveedor);
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null) return NotFound();

            var producto = AlmacenManager.Instance.ObtenerProveedor((int)id);

            if (producto == null) return NotFound();

            return View(producto);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            AlmacenManager.Instance.EliminarProveedor((int)id);
            return RedirectToAction("List");
        }
    }
}
