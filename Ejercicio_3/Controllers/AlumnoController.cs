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

        public IActionResult Actualizar_alumno(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Actualizar_alumno (Alumno a, int id)
        {
            if (ModelState.IsValid)
            {
                CRUD.actualizarAlumno(a, id);
                return RedirectToAction("Ver_alumno");
            }
            return View();
        }

        public IActionResult Eliminar_alumno_yes(int id)
        {
            bool recibir = CRUD.evaluarParaeliminarAlumno(id);
            if (recibir == false)
            {
                return RedirectToAction("Eliminar_alumno_no");
            }
            else
            {
                CRUD.eliminarAlumno(id);
            }

            return View();
        }

        public IActionResult Eliminar_alumno_no()
        {
            return View();
        }

    }
}