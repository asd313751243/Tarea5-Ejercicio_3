using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_3.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Ver_alumno()
        {
            return View();
        }

        public IActionResult Agregar_alumno()
        {
            return View();
        }

        public IActionResult Actualizar_alumno()
        {
            return View();
        }

        public IActionResult Eliminar_alumno()
        {
            return View();
        }

    }
}