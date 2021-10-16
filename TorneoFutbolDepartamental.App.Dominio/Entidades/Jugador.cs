using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDepartamental.App.Dominio
{
    public class Jugador : Persona
    {
        public int JugadorId { get; set; }
        [Required(ErrorMessage = "Ingrese el numero del jugador")]
        [Range(0, 50, ErrorMessage = "Debe insertar un numero entre 0 y 50")]
        [Display(Name = "Numero")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Ingrese la posicion del jugador")]
        [StringLength(20, ErrorMessage = "El maximo es de 20 caracteres")]
        [Display(Name = "Posicion")]
        public string Posicion { get; set; }
        [Required(ErrorMessage = "El equipo es obligatorio")]
        [StringLength(20, ErrorMessage = "El maximo es de 20 caracteres")]
        [Display(Name = "Equipo")]
        public string Equipo { get; set; }
    }
}