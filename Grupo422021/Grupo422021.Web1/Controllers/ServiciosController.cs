using Grupo422021.Web1.Data;
using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
