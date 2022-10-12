using InmobiliariaSosa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace InmobiliariaSosa
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
		{
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = 1, Nombre = "admin",Apellido="admin",Email="admin@mail.com",Rol=1,Avatar= "/Uploads\avatar_1.jpg" ,Clave = "GAKKw6Co5EiIGNiZC1OfQC6offL+e8CoEs3SX0LIrHA=" });// w123
        }
        public DbSet<Contrato> Contrato { get; set; }
		public DbSet<Garante> Garante { get; set; }
		public DbSet<Inquilino> Inquilino { get; set; }
		public DbSet<Inmueble> Inmueble{ get; set; }
		public DbSet<Propietario> Propietario { get; set; }
		public DbSet<Pago> Pago { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
