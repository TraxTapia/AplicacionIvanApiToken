namespace Api.Models.web.BDCliente
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contacto")]
    public partial class Contacto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contacto()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NumeroTelefono { get; set; }

        [Required]
        [StringLength(100)]
        public string NumeroCelular { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
