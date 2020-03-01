using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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