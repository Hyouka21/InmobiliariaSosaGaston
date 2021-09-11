using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class Contrato
    {
		[Display(Name = "Código")]
		public int Id { get; set; }
		[Required]
		[Display(Name = "Inquilino")]
		public int IdInquilino { get; set; }
		[Required]
		[Display(Name = "Inmueble")]
		public int IdInmueble { get; set; }
		[Required]
		[Display(Name = "Desde")]
		public DateTime FechaDesde { get; set; }
		[Required]
		[Display(Name = "Hasta")]
		public DateTime FechaHasta { get; set; }

		[Required]
		[Display(Name = "Garante")]
		public int IdGarante { get; set; }

		public DateTime? FechaCancelado { get; set; }
		public Inquilino Inquilino { get; set; }
		public Inmueble Inmueble { get; set; }
		public Garante Garante { get; set; }
		public decimal Precio { get; set; }
		public int Estado { get; set; }

	}
}
