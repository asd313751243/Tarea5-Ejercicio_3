using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio_3.Models;
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

        [HttpPost]
        public IActionResult Agregar_alumno(Alumno a)
        {
            if (ModelState.IsValid)
            {
                CRUD.agregarAlumno(a);
                return RedirectToAction("Ver_alumno");
            }
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