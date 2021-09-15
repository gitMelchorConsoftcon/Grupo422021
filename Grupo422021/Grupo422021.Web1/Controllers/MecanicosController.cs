using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Grupo422021.Web1.Controllers
{
    public class MecanicosController : Controller
    {
        List<Mecanico> mecanicos = new List<Mecanico>();

        public MecanicosController()
        {
            mecanicos.Add(new Mecanico
            {
                IdMecanico = 1,
                Nombre = "Pedro",
                ApellidoPaterno = "Perez",
                ApellidoMaterno = "Perez",
                Telefono = "6677909090"
            });

            mecanicos.Add(new Mecanico
            {
                IdMecanico = 2,
                Nombre = "Juan Pablo",
                ApellidoPaterno = "Lopez",
                ApellidoMaterno = "Lopez",
                Telefono = "6677909091"
            });
        }

        [HttpGet]
        public IActionResult Index()
        {


            return View(mecanicos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var mecanico = new Mecanico();
            return View(mecanico);
        }

        [HttpPost]
        public IActionResult Create(Mecanico mecanico)
        {
            if (ModelState.IsValid)
            {
                mecanicos.Add(mecanico);
                return RedirectToAction("Index");
            }


            return View(mecanico);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var mecanico = mecanicos.Where(x => x.IdMecanico == id).FirstOrDefault();

            if (mecanico == null)
                return RedirectToAction("Index");

            return View(mecanico);
        }

       [HttpPost]
       public IActionResult Edit(int id, Mecanico mecanico)
        {
            if (ModelState.IsValid)
            {
                var mencanico = mecanicos.Where(x=> x.IdMecanico==id).FirstOrDefault();

                mencanico.Nombre = mecanico.Nombre;
                mecanico.ApellidoPaterno = mecanico.ApellidoPaterno;
                mecanico.ApellidoMaterno = mecanico.ApellidoMaterno;
                mencanico.Telefono = mencanico.Telefono;

                return RedirectToAction("Index");
            }

            return View(mecanico);
        }


        [HttpGet]
        public IActionResult Delete (int id )
        {

            var mecanico = mecanicos.Where(x => x.IdMecanico == id).FirstOrDefault();

            mecanicos.Remove(mecanico);
          return RedirectToAction("Index");
           
        }

    }
}
