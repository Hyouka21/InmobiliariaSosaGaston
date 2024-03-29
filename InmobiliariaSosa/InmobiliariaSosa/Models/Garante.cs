﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class Garante
    {
		[Display(Name = "Código")]
		public int Id { get; set; }
		[Required]
		public string Nombre { get; set; }
		[Required]

		public string Apellido { get; set; }
		[Required]
		public string Dni { get; set; }
		[Required]
		[Display(Name = "Teléfono")]
		public string Telefono { get; set; }
		
		[Required]
		public string Email { get; set; }
		

	}
}
