namespace Api.Models.web.BDCliente
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatalogoCP")]
    public partial class CatalogoCP
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string CodigoPostal { get; set; }
        [Required]
        [StringLength(250)]
        public string Colonia { get; set; }

        [Required]
        [StringLength(250)]
        public string Municipio { get; set; }

        [Required]
        [StringLength(250)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(250)]
        public string Estado { get; set; }
    }
}
