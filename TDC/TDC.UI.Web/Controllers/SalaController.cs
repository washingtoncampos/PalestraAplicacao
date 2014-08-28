using System.Collections.Generic;
using System.Web.Mvc;
using TDC.UI.Web.Models;

namespace TDC.UI.Web.Controllers
{
    public class SalaController : Controller
    {

        public ActionResult Index()
        {
            var lista = new List<Sala>
            {
                new Sala() {Nome = "Sala Minhoca"},
                new Sala() {Nome = "Sala Sucupira"},
                new Sala() {Nome = "Sala Castanheira"}
            };
            return View(lista);
        }
        
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Sala sala)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(sala);
        }


    }
}

