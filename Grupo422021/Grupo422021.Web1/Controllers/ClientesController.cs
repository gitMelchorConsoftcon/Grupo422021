using Grupo422021.Web1.Interfaces;
using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grupo422021.Web1.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IRepositorioGenerico<Cliente> _contexto;

        public ClientesController(IRepositorioGenerico<Cliente> contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_contexto.Listar());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var Cliente = new Cliente();
            return View(Cliente);
        }

        [HttpPost]
        public IActionResult Create(Cliente obj)
        {
            if (ModelState.IsValid)
            {
                _contexto.Guardar(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var Cliente = _contexto.Buscar(id);

            if (Cliente == null)
                return RedirectToAction("Index");

            return View(Cliente);
        }

        [HttpPost]
        public IActionResult Edit(int id, Cliente obj)
        {
            if (ModelState.IsValid)
            {
                _contexto.Modificar(id, obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            _contexto.Borrar(id);
            return RedirectToAction("Index");

        }
    }
}
