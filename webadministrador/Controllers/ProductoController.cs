using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.c2_aplicacion;
using Modelo.c3_dominio.entidad.servicios;
using Modelo.c3_dominio.entidad;
namespace webadministrador.Controllers
{
    public class ProductoController : Controller
    {
        GestionarCategoriaServicio gestionarCategoriaServicio = new GestionarCategoriaServicio();
        GestionarContactoServicio gestionarContactoServicio = new GestionarContactoServicio();
        GestionarSubCategoriaServicio gestionarSubCategoriaServicio = new GestionarSubCategoriaServicio();
        GestionarLineaSubCategoriaServicio gestionarLineaSubCategoriaservicio = new GestionarLineaSubCategoriaServicio();
        GestionarProductoServicio gestionarProductoServicio = new GestionarProductoServicio();
        // GET: Producto
        public ActionResult Index(int codigolinea)
        {
            try
            {
                LineaSubCategoria lineaSubcategoria = gestionarLineaSubCategoriaservicio.buscarLineaSubCategoria(codigolinea);
                ContactoServicio contactoCategoria = new ContactoServicio(gestionarContactoServicio.listaContactos(),
                gestionarCategoriaServicio.listarCategorias(), gestionarProductoServicio.buscarProductos(lineaSubcategoria), lineaSubcategoria);
                return View(contactoCategoria);
            }
            catch (Exception e)
            {
                ContactoServicio contactoServicio = new ContactoServicio();
                contactoServicio.mensajeError = e.Message;
                return View("Error", contactoServicio);
            }
        }
        public ActionResult Eliminar(int codigo)
        {
            Producto producto = gestionarProductoServicio.buscarProducto(codigo);
            try
            {
                gestionarProductoServicio.eliminarProducto(producto);
                return RedirectToAction("Index", new { codigolineasubcategoria = producto.codigolineasubcategoria });
            }
            catch (Exception)
            {
                return RedirectToAction("Index", new { codigolineasubcategoria = producto.codigolineasubcategoria });
            }
        }
    }
}