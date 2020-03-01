using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio_3.Models;
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

        [HttpPost]
        public IActionResult Agregar_universidad_tiene_docente(Universidad_Tiene_Docente ud)
        {
            if (ModelState.IsValid)
            {
                string nom_universidad = CRUD.Universidads[ud.Id_Universidad].Nombre_Universidad;
                string nom_docente = CRUD.Docentes[ud.Id_Docente].Nombre_Docente;

                CRUD.agregarUniversidad_Tiene_Docente(ud,nom_universidad,nom_docente);
                return RedirectToAction("Ver_universidad_tiene_docente");
            }
            return View();
        }

        public IActionResult Actualizar_universidad_tiene_docente(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Actualizar_universidad_tiene_docente (Universidad_Tiene_Docente ud, int id)
        {
            if (ModelState.IsValid)
            {
                string nom_universidad = CRUD.Universidads[ud.Id_Universidad].Nombre_Universidad;
                string nom_docente = CRUD.Docentes[ud.Id_Docente].Nombre_Docente;

                CRUD.actualizarUniversidad_Tiene_Docente(ud, id, nom_universidad, nom_docente);
                return RedirectToAction("Ver_universidad_tiene_docente");
            }
            return View();
        }

        public IActionResult Eliminar_universidad_tiene_docente()
        {
            return View();
        }
    }
}