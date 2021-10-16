using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class Propietario
    {
		[Display(Name = "Código")]
		[Key]
		public int idPropietario { get; set; }
		[Required]
		[Display(Name = "Nombre")]
		public string nombre { get; set; }
		[Required]
		[Display(Name = "Apellido")]
		public string apellido { get; set; }
		[Required]
		[Display(Name = "Dni")]
		public string dni { get; set; }
		[Required]
		[Display(Name = "Teléfono")]
		public string telefono { get; set; }
		[Required]
		[Display(Name = "Email")]
		public string email { get; set; }
		
		public string clave { get; set; }
		public int avatar { get; set; }

	}
}
