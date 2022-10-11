using InmobiliariaSosa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
		{
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
