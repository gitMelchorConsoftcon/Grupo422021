using Grupo422021.Web1.Data;
using Grupo422021.Web1.Interfaces;
using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grupo422021.Web1.Controllers
{
    public class MarcasController : Controller
    {
        private readonly IRepositorioGenerico<Marca> _contexto;


        private readonly DataContext _db;
        public MarcasController(DataContext db, IRepositorioGenerico<Marca> contexto)
        {
            _db = db;
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
            var marca = _db.Marcas.Find(id);

            if (marca == null)
                return RedirectToAction("Index");

            return View(marca);
        }

        [HttpPost]
        public IActionResult Edit(int id, Marca obj)
        {
            if (ModelState.IsValid)
            {
                var modificar = _db.Marcas.Find(id);
                if (modificar == null)
                    return RedirectToAction("index");
                
                modificar.Nombre = obj.Nombre;
                modificar.Activo = obj.Activo;
                _db.Marcas.Update(modificar);
                _db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
          var borrar=  _db.Marcas.Find(id);
            if (borrar == null)
                return RedirectToAction("Index");
            _db.Marcas.Remove(borrar);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
