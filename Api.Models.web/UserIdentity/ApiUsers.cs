namespace Api.Models.web.UserIdentity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiUsers
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserPasswd { get; set; }

        [StringLength(50)]
        public string UserRole { get; set; }
    }
}
