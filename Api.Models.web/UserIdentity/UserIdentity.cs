using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Api.Models.web.UserIdentity
{
    public partial class UserIdentity : DbContext
    {
        public UserIdentity()
            : base("name=UserIdentity")
        {
        }

        public virtual DbSet<ApiUsers> ApiUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
