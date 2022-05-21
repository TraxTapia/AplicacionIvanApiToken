namespace Api.Models.web.BDCliente
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(250)]
        public string ApPaterno { get; set; }

        [Required]
        [StringLength(250)]
        public string ApMaterno { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public int? IdDomicilio { get; set; }

        public int? IdContacto { get; set; }

        public int Activo { get; set; }

        public virtual Contacto Contacto { get; set; }

        public virtual Domicilio Domicilio { get; set; }
    }
}
