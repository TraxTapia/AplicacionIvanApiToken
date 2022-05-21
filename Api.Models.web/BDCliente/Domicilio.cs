namespace Api.Models.web.BDCliente
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Domicilio")]
    public partial class Domicilio:CatalogoCP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Domicilio()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Calle { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroExterior { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroInterior { get; set; }

        [Required]
        [StringLength(50)]
        public string CodigoPostal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
