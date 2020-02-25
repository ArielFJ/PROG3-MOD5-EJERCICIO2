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
                return View("List");
            }
            return View(producto);
        }
    }
}
