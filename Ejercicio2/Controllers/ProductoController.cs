using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio2.Controllers
{
    public class ProductoController : Controller
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
        public IActionResult Agregar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                AlmacenManager.Instance.AgregarProducto(producto);
                return RedirectToAction("List");
            }
            return View(producto);
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null) return NotFound();

            var producto = AlmacenManager.Instance.ObtenerProducto((int)id);

            if (producto == null) return NotFound();

            return View(producto);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {

            AlmacenManager.Instance.EliminarProducto((int)id);
            return RedirectToAction("List");
        }
    }
}
