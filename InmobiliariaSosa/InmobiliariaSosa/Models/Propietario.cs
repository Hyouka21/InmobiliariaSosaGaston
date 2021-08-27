using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class Propietario
    {
		[Display(Name = "Codigo")]
		public int idPropietario { get; set; }
		[Required]
		public string nombre { get; set; }
		[Required]
		public string apellido { get; set; }
		[Required]
		public string dni { get; set; }
		[Required]
		public string telefono { get; set; }
		[Required]

		public string email { get; set; }
		[Required]

		public string clave { get; set; }

	}
}
