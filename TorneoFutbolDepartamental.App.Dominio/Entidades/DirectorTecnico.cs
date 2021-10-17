using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDepartamental.App.Dominio
{
    public class DirectorTecnico : Persona
    {
        public int DirectorTecnicoId { get; set; }
        [Required(ErrorMessage = "El Equipo es obligatorio")]
        [StringLength(20, ErrorMessage = "El maximo es de 20 caracteres")]
        [Display(Name = "Equipo")]
        public string Equipo { get; set; }
    }
}