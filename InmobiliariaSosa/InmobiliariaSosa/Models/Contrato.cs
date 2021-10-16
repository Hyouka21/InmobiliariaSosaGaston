using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class Contrato
    {
		[Display(Name = "Código")]
		[Key]
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
		[NotMapped]
		public Inquilino Inquilino { get; set; }
		[NotMapped]
		public Inmueble Inmueble { get; set; }
		[NotMapped]
		public Garante Garante { get; set; }
		public decimal Precio { get; set; }
		public byte Estado { get; set; }

	}
}
