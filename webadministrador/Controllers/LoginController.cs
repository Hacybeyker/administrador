using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.c3_dominio.entidad;
using Modelo.c2_aplicacion;

namespace webadministrador.Controllers
{
    public class LoginController : Controller
    {
        GestionarUsuarioServicio gestionarUsuarioServicio = new GestionarUsuarioServicio();
        // GET: Login
        public ActionResult Index()
        {
            if(Session["LogedUserFullname"] != null)
            {
                Session.Remove("LogedUserID");
                Session.Remove("LogedUserFullname");
                Session["LogedUserID"] = null;
                Session["LogedUserFullname"] = null;
                return View("Index");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "cuentaUsuario,claveUsuario")] Usuario usuario)
        {            
            if (ModelState.IsValid)
            {
                Usuario user = gestionarUsuarioServicio.buscarUsuario(usuario.cuentaUsuario,usuario.claveUsuario);
                if (user != null)
                {
                    Session["LogedUserID"] = user.codigoUsuario.ToString();
                    Session["LogedUserFullname"] = user.nombreUsuario.ToString();
                    return RedirectToAction("Index","Home");
                }
            }
            return View("Index");
        }
    }
}