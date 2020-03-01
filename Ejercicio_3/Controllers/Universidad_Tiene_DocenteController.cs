using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_3.Controllers
{
    public class Universidad_Tiene_DocenteController : Controller
    {
        public IActionResult Ver_universidad_tiene_docente()
        {
            return View();
        }

        public IActionResult Agregar_universidad_tiene_docente()
        {
            return View();
        }

        public IActionResult Actualizar_universidad_tiene_docente()
        {
            return View();
        }

        public IActionResult Eliminar_universidad_tiene_docente()
        {
            return View();
        }
    }
}