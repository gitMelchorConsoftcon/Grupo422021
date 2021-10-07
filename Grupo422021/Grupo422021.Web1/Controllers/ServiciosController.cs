using Grupo422021.Web1.Data;
using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Grupo422021.Web1.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly DataContext _contexto;

        public ServiciosController(DataContext contexto)
        {
            _contexto = contexto;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var servicios = _contexto.Servicios;

            return View(servicios.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var servicio = new Servicio();
            return View(servicio);
        }
        [HttpPost]
        public IActionResult Create(Servicio servicio)
        {
            if (ModelState.IsValid)
            {

                _contexto.Servicios.Add(servicio);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }


            return View(servicio);
        }
    
    
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var servicio = _contexto.Servicios.Find(id);
            return View(servicio);
        }


        [HttpPost]
        public IActionResult Edit(int id,Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                var modificar = _contexto.Servicios.Find(id);

                modificar.Nombre = servicio.Nombre;
                modificar.Descripcion = servicio.Descripcion;
                modificar.Activo = servicio.Activo;

                _contexto.Entry(modificar).State = EntityState.Modified;
                _contexto.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(servicio);
        }
    

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var borrar = _contexto.Servicios.Find(id);

            _contexto.Servicios.Remove(borrar);
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
