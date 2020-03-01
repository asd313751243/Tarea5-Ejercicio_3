using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_3.Controllers
{
    public class MaestriaController : Controller
    {
        public IActionResult Ver_maestria()
        {
            return View();
        }

        public IActionResult Agregar_maestria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar_maestria(Maestria m)
        {
            if (ModelState.IsValid)
            {
                CRUD.agregarMaestria(m);
                return RedirectToAction("Ver_maestria");
            }
            return View();
        }

        public IActionResult Actualizar_maestria(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Actualizar_maestria (Maestria m, int id)
        {
            if (ModelState.IsValid)
            {
                CRUD.actualizarMaestria(m, id);
                return RedirectToAction("Ver_maestria");
            }
            return View();
        }

        public IActionResult Eliminar_maestria_yes(int id)
        {
            bool recibir = CRUD.evaluarParaeliminarMaestria(id);
            if (recibir == false)
            {
                return RedirectToAction("Eliminar_maestria_no");
            }
            else
            {
                CRUD.eliminarMaestria(id);
            }

            return View();

        }

        public IActionResult Eliminar_maestria_no()
        {
            return View();
        }

    }
}