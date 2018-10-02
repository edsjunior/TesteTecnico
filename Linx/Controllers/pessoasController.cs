using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Linx.Models;
using System;

namespace Linx.Controllers
{
    public class PessoasController : Controller
    {
        private Contexto db = new Contexto();


        public ActionResult Exercicio1()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Exercicio1([Bind(Include = "Cod_pessoa,Nom_Pessoa,Nom_Profissao")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                return RedirectToAction("Exercicio3");
            }
            return View(pessoa);
        }

        public ActionResult Exercicio2(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Exercicio2([Bind(Include = "Cod_pessoa,Nom_Pessoa,Nom_Profissao")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Exercicio3");
            }
            return View(pessoa);
        }

        public ActionResult Exercicio3(int? id)
        {
            if (id == null)
            {
                return View(db.Pessoas.ToList());
            }
            else
            {
                var query = db.Pessoas.Take(Convert.ToInt32(id));
                return View(query);
            }
        }
        public ActionResult Exercicio4()
        {
            return View();
        }
        public ActionResult Exercicio7()
        {
            return View();
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            db.Pessoas.Remove(pessoa);
            db.SaveChanges();
            return RedirectToAction("Exercicio3");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
