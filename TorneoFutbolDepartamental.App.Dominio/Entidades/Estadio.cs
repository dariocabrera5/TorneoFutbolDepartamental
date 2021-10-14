using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDepartamental.App.Dominio
{
    public class Estadio
    {
        public int EstadioId {get;set;}
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "El maximo es de 20 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre {get;set;}
        [Required(ErrorMessage = "La direccion es obligatoria")]
        [StringLength(20, ErrorMessage = "El maximo es de 20 caracteres")]
        [Display(Name = "Direccion")]
        public string Direccion {get;set;}
        [Required(ErrorMessage = "La ciudad es obligatoria")]
        [StringLength(20, ErrorMessage = "El maximo es de 20 caracteres")]
        [Display(Name = "Ciudad")]
        public string Ciudad {get;set;}
        public Municipio Municipio {get;set;}
    }
}