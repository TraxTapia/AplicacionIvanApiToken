using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Models.web.Request
{
   public class UpdateClienteRequest
    {

        public int Id { get; set; }

        [Required]
      [Range(0,int.MaxValue,ErrorMessage ="Se encontraron valores negativos en el id")]
        public string Nombre { get; set; }

        [Required]
        public string ApPaterno { get; set; }

        [Required]
        public string ApMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Se encontraron valores negativos en el id")]
        public int? IdDomicilio { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Se encontraron valores negativos en el id")]
        public int? IdContacto { get; set; }

    }
}
