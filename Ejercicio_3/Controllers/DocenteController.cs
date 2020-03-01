using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio_3.Models;
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

        [HttpPost]
        public IActionResult Agregar_docente(Docente d)
        {
            if (ModelState.IsValid)
            {
                CRUD.agregarDocente(d);
                return RedirectToAction("Ver_docente");
            }
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