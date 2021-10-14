using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDepartamental.App.Dominio
{
    public class Arbitro : Persona
    {
        public int ArbitroId { get; set; }
        [Required(ErrorMessage = "El Colegio al que pertenece es obligatorio")]
        [StringLength(50, ErrorMessage = "El maximo es de 50 caracteres")]
        [Display(Name = "Colegio al que pertenece")]
        public string ColegioPertenece { get; set; }
    }
}
