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
    public class CadastroFuncionarioController : Controller
    {
        private funcionarioEntities4 db = new funcionarioEntities4();

        // GET: CadastroFuncionario
        public ActionResult Index()
        {
            return View(db.Funcionario_Empresa.ToList());
        }

        // GET: CadastroFuncionario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario_Empresa funcionario_Empresa = db.Funcionario_Empresa.Find(id);
            if (funcionario_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(funcionario_Empresa);
        }

        // GET: CadastroFuncionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroFuncionario/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFuncionario,Empresa,CPF,Nome,ID_Usuario,Data_Nascimento,RG")] Funcionario_Empresa funcionario_Empresa)
        {
            if (ModelState.IsValid)
            {
                db.Funcionario_Empresa.Add(funcionario_Empresa);
                db.SaveChanges();
                return RedirectToAction("FormSucessoFuncionario", "FormularioSucesso");
            }

            return View(funcionario_Empresa);
        }

        // GET: CadastroFuncionario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario_Empresa funcionario_Empresa = db.Funcionario_Empresa.Find(id);
            if (funcionario_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(funcionario_Empresa);
        }

        // POST: CadastroFuncionario/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFuncionario,Empresa,CPF,Nome,ID_Usuario,Data_Nascimento,RG")] Funcionario_Empresa funcionario_Empresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionario_Empresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcionario_Empresa);
        }

        // GET: CadastroFuncionario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario_Empresa funcionario_Empresa = db.Funcionario_Empresa.Find(id);
            if (funcionario_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(funcionario_Empresa);
        }

        // POST: CadastroFuncionario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionario_Empresa funcionario_Empresa = db.Funcionario_Empresa.Find(id);
            db.Funcionario_Empresa.Remove(funcionario_Empresa);
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
