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
    public class EstudanteController : Controller
    {
        private funcionarioEntities4 db = new funcionarioEntities4();

        // GET: Estudante
        public ActionResult Index()
        {
            return View(db.Estudantes.ToList());
        }

        // GET: Estudante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudantes.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // GET: Estudante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudante/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFuncionario,Nome_Instituicao,CPF,Bairro,Endereco,Cidade,CEP,Nome_Aluno,RG_Aluno,Nome_Responsavel,RG_Responsavel,Data_Nascimento,Email")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Estudantes.Add(estudante);
                db.SaveChanges();
                return RedirectToAction("FormSucessoEstudante", "FormularioSucesso");
            }

            return View(estudante);
        }

        // GET: Estudante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudantes.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // POST: Estudante/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFuncionario,Nome_Instituicao,CPF,Bairro,Endereco,Cidade,CEP,Nome_Aluno,RG_Aluno,Nome_Responsavel,RG_Responsavel,Data_Nascimento,Email")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estudante);
        }

        // GET: Estudante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudantes.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // POST: Estudante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estudante estudante = db.Estudantes.Find(id);
            db.Estudantes.Remove(estudante);
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
