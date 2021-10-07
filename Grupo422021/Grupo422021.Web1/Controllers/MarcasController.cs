using Grupo422021.Web1.Interfaces;
using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grupo422021.Web1.Controllers
{
    public class MarcasController : Controller
    {
        private readonly IRepositorioGenerico<Marca> _contexto;

        public MarcasController(IRepositorioGenerico<Marca> contexto)
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
            var Marca = new Marca();
            return View(Marca);
        }

        [HttpPost]
        public IActionResult Create(Marca obj)
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
            var Marca = _contexto.Buscar(id);

            if (Marca == null)
                return RedirectToAction("Index");

            return View(Marca);
        }

        [HttpPost]
        public IActionResult Edit(int id, Marca obj)
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
