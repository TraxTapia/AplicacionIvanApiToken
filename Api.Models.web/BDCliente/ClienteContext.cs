using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Api.Models.web.BDCliente
{
    public partial class ClienteContext : DbContext
    {
        public ClienteContext()
            : base("name=ClienteContext")
        {
            this.Database.CommandTimeout = 500;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<CatalogoCP> CatalogoCP { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogoCP>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoCP>()
                .Property(e => e.Municipio)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoCP>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoCP>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.ApPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.ApMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.NumeroTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.NumeroCelular)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .HasMany(e => e.Cliente)
                .WithOptional(e => e.Contacto)
                .HasForeignKey(e => e.IdContacto);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.NumeroExterior)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.NumeroInterior)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .HasMany(e => e.Cliente)
                .WithOptional(e => e.Domicilio)
                .HasForeignKey(e => e.IdDomicilio);
        }
    }
}
