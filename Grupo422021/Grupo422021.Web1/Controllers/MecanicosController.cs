using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Grupo422021.Web1.Controllers
{
    public class MecanicosController : Controller
    {

        public IActionResult Index()
        {
            var mecanicos = new List<string>();

            mecanicos.Add("Melchor");
            mecanicos.Add("Gabriel");
            mecanicos.Add("Pedro");
            mecanicos.Add("Juan");
            mecanicos.Add("Marcos");

            return View(mecanicos);
        }
    }
}
