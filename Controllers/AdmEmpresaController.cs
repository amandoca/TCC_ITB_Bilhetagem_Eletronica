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
    public class AdmEmpresaController : Controller
    {
        private funcionarioEntities4 db = new funcionarioEntities4();

        // GET: Adm
        public ActionResult Index()
        {
            return View(db.Cadastro_Empresa.ToList());
        }

        // GET: Adm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Empresa cadastro_Empresa = db.Cadastro_Empresa.Find(id);
            if (cadastro_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Empresa);
        }

        // GET: Adm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFuncionario,Empresa,CNPJ,Telefone,Email,Endereco,Bairro,Numero,CEP,Cidade,Senha")] Cadastro_Empresa cadastro_Empresa)
        {
            if (ModelState.IsValid)
            {
                db.Cadastro_Empresa.Add(cadastro_Empresa);
                db.SaveChanges();
                return RedirectToAction("FormSucessoEmpresa", "FormularioSucesso");
            }

            return View(cadastro_Empresa);
        }

        // GET: Adm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Empresa cadastro_Empresa = db.Cadastro_Empresa.Find(id);
            if (cadastro_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Empresa);
        }

        // POST: Adm/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFuncionario,Empresa,CNPJ,Telefone,Email,Endereco,Bairro,Numero,CEP,Cidade,Senha")] Cadastro_Empresa cadastro_Empresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastro_Empresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastro_Empresa);
        }

        // GET: Adm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro_Empresa cadastro_Empresa = db.Cadastro_Empresa.Find(id);
            if (cadastro_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(cadastro_Empresa);
        }

        // POST: Adm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cadastro_Empresa cadastro_Empresa = db.Cadastro_Empresa.Find(id);
            db.Cadastro_Empresa.Remove(cadastro_Empresa);
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
            if (Session["empresaUsuarioLogado"] != null)
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

