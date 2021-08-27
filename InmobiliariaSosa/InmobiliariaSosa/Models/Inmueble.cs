using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class Inmueble
    {
        [Display(Name = "Codigo")]
        public int Id { get; set; }
        public string Direccion { get; set; }
        [Required]
        public int Ambiente { get; set; }
        [Required]
        public int Superficie { get; set; }
        [Required]

        public decimal Latitud { get; set; }
        [Required]
        public decimal Longitud { get; set; }
        [Required]
        [Display(Name = "Dueño")]
        public int IdPropietario { get; set; }
        public Propietario Duenio { get; set; }

    }
}
