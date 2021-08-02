using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoTCC.Models;

namespace ProjetoTCC.Controllers
{
    public class AdmSistemaController : Controller
    {
        private funcionarioEntities4 db = new funcionarioEntities4();

        // GET: AdmSistema
        // GET: AdmSistema
        public ActionResult Index()
        {
            return View(db.Cadastro_Adm.ToList());
        }

        // GET: AdmSistema/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Adm cadastro_Adm = db.Cadastro_Adm.Find(id);
            if (cadastro_Adm == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Adm);
        }

        // GET: AdmSistema/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmSistema/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFuncionario,Nome,Viacao,Senha")] Cadastro_Adm cadastro_Adm)
        {
            List<String> listaViacao = new List<string>();
            listaViacao.Add("Ralip");
            listaViacao.Add("Benfica BBTT");
            ViewBag.status = listaViacao;

            if (ModelState.IsValid)
            {
                db.Cadastro_Adm.Add(cadastro_Adm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadastro_Adm);
        }

        // GET: AdmSistema/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Adm cadastro_Adm = db.Cadastro_Adm.Find(id);
            if (cadastro_Adm == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Adm);
        }

        // POST: AdmSistema/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFuncionario,Nome,Viacao,Senha")] Cadastro_Adm cadastro_Adm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastro_Adm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastro_Adm);
        }

        // GET: AdmSistema/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Adm cadastro_Adm = db.Cadastro_Adm.Find(id);
            if (cadastro_Adm == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Adm);
        }

        // POST: AdmSistema/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cadastro_Adm cadastro_Adm = db.Cadastro_Adm.Find(id);
            db.Cadastro_Adm.Remove(cadastro_Adm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Administrar()

        {
            if (Session["nomeUsuarioLogado"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}
