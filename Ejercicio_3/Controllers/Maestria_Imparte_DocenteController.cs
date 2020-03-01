using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_3.Controllers
{
    public class Maestria_Imparte_DocenteController : Controller
    {
        public IActionResult Ver_maestria_imparte_docente()
        {
            return View();
        }

        public IActionResult Agregar_maestria_imparte_docente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar_maestria_imparte_docente(Maestria_Imparte_Docente md)
        {
            if (ModelState.IsValid)
            {
                string nom_maestria = CRUD.Maestrias[md.Id_Maestria].Nombre_Maestria;
                string nom_docente = CRUD.Docentes[md.Id_Docente].Nombre_Docente;
                CRUD.agregarMaestria_Imparte_Docente(md,nom_maestria,nom_docente);
                return RedirectToAction("Ver_maestria_imparte_docente");
            }
            return View();
        }

        public IActionResult Actualizar_maestria_imparte_docente()
        {
            return View();
        }

        public IActionResult Eliminar_maestria_imparte_docente()
        {
            return View();
        }

    }
}