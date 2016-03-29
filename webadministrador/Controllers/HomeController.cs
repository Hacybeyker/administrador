using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.c2_aplicacion;
using Modelo.c3_dominio.entidad;
using Modelo.c3_dominio.entidad.servicios;
namespace webadministrador.Controllers
{
    public class HomeController : Controller
    {

        public GestionarContactoServicio gestionarContactoServicio = new GestionarContactoServicio();
        public GestionarCategoriaServicio gestionarCategoriaServicio=  new GestionarCategoriaServicio();
        public ActionResult Index()
        {
            
            ContactoServicio contactoServicio = new ContactoServicio(gestionarContactoServicio.listaContactos(),gestionarCategoriaServicio.listarCategorias());
            return View(contactoServicio);
        }
        public ActionResult MostrarContacto(int codigocontacto)
        {
            gestionarContactoServicio.agregarVisto(new Contacto(codigocontacto));
            ContactoServicio contactoCategoria = new ContactoServicio(gestionarContactoServicio.listaContactos(),gestionarContactoServicio.buscarContacto(codigocontacto),gestionarCategoriaServicio.listarCategorias());
            return View(contactoCategoria);
        }
       

    }
}