using Grupo422021.Web1.Data;
using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Grupo422021.Web1.Controllers
{
    public class MecanicosController : Controller
    {
        private readonly DataContext _contexto;

        public MecanicosController(DataContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaMecanicos = _contexto.Mecanicos;

            return View(listaMecanicos.ToList());
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

                _contexto.Mecanicos.Add(mecanico);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }


            return View(mecanico);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var mecanico = _contexto.Mecanicos.Find(id);

            if (mecanico == null)
                return RedirectToAction("Index");

            return View(mecanico);
        }

       [HttpPost]
       public IActionResult Edit(int id, Mecanico mecanico)
        {
            if (ModelState.IsValid)
            {
               var mencanico = _contexto.Mecanicos.Find(id);

                mencanico.Nombre = mecanico.Nombre;
                mecanico.ApellidoPaterno = mecanico.ApellidoPaterno;
                mecanico.ApellidoMaterno = mecanico.ApellidoMaterno;
                mencanico.Telefono = mencanico.Telefono;

                _contexto.Entry(mecanico).State = EntityState.Modified;
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(mecanico);
        }


        [HttpGet]
        public IActionResult Delete (int id )
        {

            var mecanico = _contexto.Mecanicos.Find(id);

            _contexto.Mecanicos.Remove(mecanico);
            _contexto.SaveChanges();
          return RedirectToAction("Index");
           
        }

    }
}
