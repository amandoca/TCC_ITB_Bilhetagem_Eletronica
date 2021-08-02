using ProjetoTCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTCC.Controllers
{
    public class PrincipalAdmController : Controller
    {
        // GET: PrincipalAdm
        public ActionResult LoginAdmSistema()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginAdmSistema(Cadastro_Adm u)
        {
            // esta action trata o post (login)
            if (!ModelState.IsValid) //verifica se é válido
            {
                return View(u);
            }
            using (funcionarioEntities4 dc = new funcionarioEntities4())
            {
                var v = dc.Cadastro_Adm.Where(a => a.Nome.Equals(u.Nome) && a.Senha.Equals(u.Senha)).FirstOrDefault();
                if (v != null)
                {
                    Session["usuarioLogadoID"] = v.idFuncionario.ToString();
                    Session["nomeUsuarioLogado"] = v.Nome.ToString();
                    return RedirectToAction("Administrar", "AdmSistema");
                }
            }
            return View(u);
        }
    }
}

