using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.c3_dominio.entidad.servicios
{
    public class ContactoServicio
    {
        public Usuario Usuario { get; set; }
        public ContactoServicio()
        {
            this.listaContacto = new List<Contacto>();
            this.listacategoria = new List<Categoria>();
        }
        public ContactoServicio(List<Contacto> listacontactos,Categoria _categoria,
            List<Categoria> listaCategorias)
        {
            this.listaContacto = listacontactos;
            this.listacategoria = listaCategorias;
            this.categoria = _categoria;
            this.subCategoria = new SubCategoria();
            this.subCategoria.codigocategoria = _categoria.codigocategoria;
        }
        public ContactoServicio(List<Contacto> listacontactos, SubCategoria _subcategoria,
          List<Categoria> listaCategorias)
        {
            this.listaContacto = listacontactos;
            this.listacategoria = listaCategorias;
            this.subCategoria = _subcategoria;
            this.lineasubcategoria = new LineaSubCategoria();
            this.lineasubcategoria.codigosubcategoria = _subcategoria.codigosubcategoria;
        }
        public ContactoServicio(List<Contacto> listacontactos, LineaSubCategoria _lineaSubcategoria,
         List<Categoria> listaCategorias)
        {
            this.listaContacto = listacontactos;
            this.listacategoria = listaCategorias;
            this.lineasubcategoria = _lineaSubcategoria;
        }
        public ContactoServicio(List<Contacto> listacontactos,Contacto _contacto,
            List<Categoria> listaCategorias)
        {
            this.listacategoria = listaCategorias;
            this.listaContacto = listacontactos;
            this.contacto = _contacto;
        }
     
        public ContactoServicio(List<Contacto> listacontactos, List<Categoria> listaCategorias, List<SubCategoria> listaSubCategorias, Categoria _categoria) {
            this.listaContacto = listacontactos;
            this.listacategoria = listaCategorias;
            this.listaSubCategoria = listaSubCategorias;
            this.categoria = _categoria;
        }
     
        public ContactoServicio(List<Contacto> listacontactos, List<Categoria> listaCategorias, List<LineaSubCategoria> listaLineaSubCategorias, SubCategoria _subcategoria)
        {
            this.listaContacto = listacontactos;
            this.listacategoria = listaCategorias;
            this.listaLineaSubCategoria = listaLineaSubCategorias;
            this.subCategoria = _subcategoria;
        }
        public ContactoServicio(List<Contacto> listacontactos, List<Categoria> listaCategorias, List<Producto> listaProductos, LineaSubCategoria _lineasubcategoria)
        {
            this.listaContacto = listacontactos;
            this.listacategoria = listaCategorias;
            this.listaProducto = listaProductos;
            this.lineasubcategoria = _lineasubcategoria;
        }
        public ContactoServicio(List<Contacto> listacontactos, List<Categoria> listaCategorias)
        {
            this.listaContacto = listacontactos;
            this.listacategoria = listaCategorias;
        }
        public List<Categoria> listacategoria { get; set; }
        public List<SubCategoria> listaSubCategoria { get; set; }
        public List<LineaSubCategoria> listaLineaSubCategoria { get; set; }
        public List<Producto> listaProducto { get; set; }
        public List<Contacto> listaContacto { get; set; }
        public Contacto contacto { get; set; }
        public Categoria categoria { get; set; }
        public SubCategoria subCategoria { get; set; }
        public LineaSubCategoria lineasubcategoria { get; set; }
        public string mensajeError { get; set; }
        public string mensajecorrecto{ get; set; }
        public int cantidadMensajeContacto()
        {
            int contador = 0;
            if (listaContacto != null)
            {
                foreach (var contacto in listaContacto)
                {
                    if (!contacto.visto)
                        contador++;
                }
            }
            else
                contador = 0;
            return contador;
        }

        public int cantidadMensaje()
        {
            return listaContacto.Count();
        }

        public int cantidadCategoria()
        {
            return listacategoria.Count();
        }


    }
}
