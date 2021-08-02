using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTCC.Controllers
{
    public class FormularioSucessoController : Controller
    {
        // GET: FormularioSucesso
        public ActionResult FormSucessoFuncionario()
        {
            return View();
        }
        public ActionResult FormSucessoEmpresa()
        {
            return View();
        }
        public ActionResult FormSucessoEstudante()
        {
            return View();
        }
        public ActionResult FormSucessoCidadao()
        {
            return View();
        }
        public ActionResult FormSucessoContato()
        {
            return View();
        }
    }
}