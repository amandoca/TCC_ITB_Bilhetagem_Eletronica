using ProjetoTCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTCC.Controllers
{
    public class PrincipalController : Controller
    {
        funcionarioEntities4 db = new funcionarioEntities4();
        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginEmpresa()
        {
            return View();
        }

        public ActionResult Cartoes()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginEmpresa(Cadastro_Empresa u)
        {
            // esta action trata o post (login)
            if (ModelState.IsValid) //verifica se é válido
            {
                using (funcionarioEntities4 dc = new funcionarioEntities4())
                {
                    var v = dc.Cadastro_Empresa.Where(a => a.Empresa.Equals(u.Empresa) && a.Senha.Equals(u.Senha)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["empresaLogadoID"] = v.idFuncionario.ToString();
                        Session["empresaUsuarioLogado"] = v.Empresa.ToString();
                        return RedirectToAction("Administrar", "AdmEmpresa");
                    }
                }
            }
            return View(u);
        }

        private Task SignInAsync(object user, object rememberMe)
        {
            throw new NotImplementedException();
        }

        private Task<ActionResult> RedirectToLocal(string returnUrl)
        {
            throw new NotImplementedException();
        }
    }

    internal class UserManager
    {
        internal static Task FindAsync(string Empresa, string senha)
        {
            throw new NotImplementedException();
        }
    }
}