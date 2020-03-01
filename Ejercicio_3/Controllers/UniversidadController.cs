using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_3.Controllers
{
    public class UniversidadController : Controller
    {
        public IActionResult Ver_universidad()
        {
            return View();
        }

        public IActionResult Agregar_universidad()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar_universidad(Universidad u)
        {
            if (ModelState.IsValid)
            {
                CRUD.agregarUniversidad(u);
                return RedirectToAction("Ver_universidad");
            }
            return View();
        }

        public IActionResult Actualizar_universidad()
        {
            return View();
        }

        public IActionResult Eliminar_universidad()
        {
            return View();
        }

    }
}