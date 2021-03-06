using Grupo422021.Web1.Interfaces;
using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grupo422021.Web1.Controllers
{
    public class MecanicosController : Controller
    {
        private readonly IRepositorioGenerico<Mecanico> _contexto;

        public MecanicosController(IRepositorioGenerico<Mecanico> contexto)
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
            var mecanico = new Mecanico();
            return View(mecanico);
        }

        [HttpPost]
        public IActionResult Create(Mecanico obj)
        {
            if (ModelState.IsValid)
            {
                _contexto.Guardar(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var mecanico = _contexto.Buscar(id);

            if (mecanico == null)
                return RedirectToAction("Index");

            return View(mecanico);
        }

       [HttpPost]
       public IActionResult Edit(int id, Mecanico obj)
        {
            if (ModelState.IsValid)
            {
                _contexto.Modificar(id, obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        [HttpGet]
        public IActionResult Delete (int id )
        {
            _contexto.Borrar(id);
          return RedirectToAction("Index");
           
        }

    }
}
