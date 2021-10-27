using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class Inmueble
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Dirección")]
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
        [NotMapped]
        public Propietario Duenio { get; set; }
        public decimal Precio { get; set; }
        public byte Estado { get; set; }
        public string Imagen { get; set; }
        [NotMapped]
        public string ImagenGuardar { get; set; }
    }
}
