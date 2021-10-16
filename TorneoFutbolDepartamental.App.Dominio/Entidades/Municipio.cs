using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDepartamental.App.Dominio
{
    public class Municipio
    {
        public int MunicipioId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "El maximo es de 20 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
    }
}