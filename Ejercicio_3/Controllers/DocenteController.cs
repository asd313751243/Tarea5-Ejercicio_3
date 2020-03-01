using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_3.Controllers
{
    public class DocenteController : Controller
    {
        public IActionResult Ver_docente()
        {
            return View();
        }

        public IActionResult Agregar_docente()
        {
            return View();
        }

        public IActionResult Actualizar_docente()
        {
            return View();
        }

        public IActionResult Eliminar_docente()
        {
            return View();
        }

    }
}