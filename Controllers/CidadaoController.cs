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
    public class CidadaoController : Controller
    {
        private funcionarioEntities4 db = new funcionarioEntities4();

        // GET: Cidadao
        public ActionResult Index()
        {
            return View(db.Cadastro_Cidadao.ToList());
        }

        // GET: Cidadao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Cidadao cadastro_Cidadao = db.Cadastro_Cidadao.Find(id);
            if (cadastro_Cidadao == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Cidadao);
        }

        // GET: Cidadao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cidadao/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFuncionario,CPF,ID_Usuario,Nome,RG,Email,Bairro,Cidade,Data_Nascimento")] Cadastro_Cidadao cadastro_Cidadao)
        {
            if (ModelState.IsValid)
            {
                db.Cadastro_Cidadao.Add(cadastro_Cidadao);
                db.SaveChanges();
                return RedirectToAction("FormSucessoCidadao", "FormularioSucesso");
            }

            return View(cadastro_Cidadao);
        }

        // GET: Cidadao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Cidadao cadastro_Cidadao = db.Cadastro_Cidadao.Find(id);
            if (cadastro_Cidadao == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Cidadao);
        }

        // POST: Cidadao/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFuncionario,CPF,ID_Usuario,Nome,RG,Email,Bairro,Cidade,Data_Nascimento")] Cadastro_Cidadao cadastro_Cidadao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastro_Cidadao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastro_Cidadao);
        }

        // GET: Cidadao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Cidadao cadastro_Cidadao = db.Cadastro_Cidadao.Find(id);
            if (cadastro_Cidadao == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Cidadao);
        }

        // POST: Cidadao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cadastro_Cidadao cadastro_Cidadao = db.Cadastro_Cidadao.Find(id);
            db.Cadastro_Cidadao.Remove(cadastro_Cidadao);
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
    }
}
