using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Models.web.Request
{
   public class ClienteRequest
    {


        [Required]
        [StringLength(250,ErrorMessage ="No puede ingresar mas de 250 caracteres")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "No puede ingresar mas de 250 caracteres")]
        public string ApPaterno { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "No puede ingresar mas de 250 caracteres")]
        public string ApMaterno { get; set; }

        [Required]
        public DateTime? FechaNacimiento { get; set; }

        public int? IdDomicilio { get; set; }

        public int? IdContacto { get; set; }

        public int Activo { get; set; }

    }
}
