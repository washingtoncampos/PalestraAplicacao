using System.Collections.Generic;
using System.Web.Mvc;
using TDC.UI.Web.Models;

namespace TDC.UI.Web.Controllers
{ // TODO:Falta criar Editar e o Excluir

    public class SalaController : Controller
    {

        public ActionResult Index()
        {
            var lista = new List<Sala>
            {
                new Sala() {Nome = "Sala Minhoca"},
                new Sala() {Nome = "Sala Sucupira"},
                new Sala() {Nome = "Sala Castanheira"},
                new Sala() {Nome = "Sala Bem-te-Vi"}

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

        public ActionResult Editar(string id)
        {

            {
                //Busca no banco por Id
                var sala = new Sala()
                {
                    Id = id,
                    Nome = "Sala 001"
                };

                if (sala == null)
                    return HttpNotFound();
                return View(sala);

            }
        }

        [HttpPost]
        public ActionResult Editar(Sala sala)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(sala);
        }

        public ActionResult Detalhe(string id)
        {

            {
                //Busca no banco por Id
                var sala = new Sala()
                {
                    Id = id,
                    Nome = "Sala 001"
                };

                if (sala == null)
                    return HttpNotFound();
                return View(sala);

            }

        }

        
        public ActionResult Excluir (string id)
        {

            {
                //Busca no banco por Id
                var sala = new Sala()
                {
                    Id = id,
                    Nome = "Sala 001"
                };

                if (sala == null)
                    return HttpNotFound();
                return View(sala);

            }
        }
        //Exclui Registro
        [HttpPost ,ActionName("Excluir")]
        public ActionResult ConfirmarExcluir(string id)
        {
            return RedirectToAction("Index");
        }

    }
}
