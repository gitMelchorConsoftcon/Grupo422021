using Grupo422021.Web1.Interfaces;
using Grupo422021.Web1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Grupo422021.Web1.Controllers
{
    public class VehiculosController : Controller
    {

        private readonly IRepositorioGenerico<Vehiculo> _contexto;
        private readonly IRepositorioGenerico<Marca> _contextoMarca;
        private readonly IRepositorioGenerico<Cliente> _contextoCliente;

        public VehiculosController(IRepositorioGenerico<Vehiculo> contexto,
                                   IRepositorioGenerico<Marca> contextoMarca,
                                   IRepositorioGenerico<Cliente> contextoCliente)
        {
            _contexto = contexto;
            _contextoMarca = contextoMarca;
            _contextoCliente = contextoCliente;
        }


        public IActionResult Index()
        {
            var lista = _contexto.Listar();
            return View(lista);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var Vehiculo = new Vehiculo();
            var marcas = _contextoMarca.Listar();
            var clientes = _contextoCliente.Listar();
            
            ViewBag.Marcas = new SelectList(marcas.ToList(), "IdMarca", "Nombre");
            ViewBag.Clientes = new SelectList(clientes.ToList(), "IdCliente", "Nombre");
          
            return View(Vehiculo);
        }

        [HttpPost]
        public IActionResult Create(Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _contexto.Guardar(vehiculo);
                return RedirectToAction("Index");
            }

            var marcas = _contextoMarca.Listar();
            var clientes = _contextoCliente.Listar();

            ViewBag.Marcas = new SelectList(marcas.ToList(), "IdMarca", "Nombre");
            ViewBag.Clientes = new SelectList(clientes.ToList(), "IdCliente", "Nombre");


            return View(vehiculo);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var vehiculo = _contexto.Buscar(id);

            var marcas = _contextoMarca.Listar();
            var clientes = _contextoCliente.Listar();

            ViewBag.Marcas = new SelectList(marcas.ToList(), "IdMarca", "Nombre");
            ViewBag.Clientes = new SelectList(clientes.ToList(), "IdCliente", "Nombre");
            return View(vehiculo);
        }

        [HttpPost]
        public IActionResult Edit(int id,Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _contexto.Modificar(id, vehiculo);
             return   RedirectToAction("index");
            }
            var marcas = _contextoMarca.Listar();
            var clientes = _contextoCliente.Listar();

            ViewBag.Marcas = new SelectList(marcas.ToList(), "IdMarca", "Nombre");
            ViewBag.Clientes = new SelectList(clientes.ToList(), "IdCliente", "Nombre");
            return View(vehiculo);

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _contexto.Borrar(id);
            return RedirectToAction("Index");

        }



    }
}
