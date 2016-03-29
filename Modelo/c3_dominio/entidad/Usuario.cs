using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelo.c3_dominio.entidad
{
    public partial class Usuario
    {
        public int codigoUsuario { get; set; }
        public string nombreUsuario { get; set; }
        [Required(ErrorMessage = "Porfavor, Ingresar Usuario", AllowEmptyStrings = false) ]
        public string cuentaUsuario { get; set; }
        [Required(ErrorMessage = "Porfavor, Ingresar Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string claveUsuario { get; set; }
        public Usuario()
        {
            this.codigoUsuario = 0;
        }
    }
}
