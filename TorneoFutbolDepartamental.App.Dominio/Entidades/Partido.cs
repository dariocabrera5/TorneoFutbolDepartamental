using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDepartamental.App.Dominio
{
    public class Partido
    {
        public int PartidoId {get;set;}
        [Required(ErrorMessage = "La fecha y hora es obligatoria")]
        [StringLength(30, ErrorMessage = "El maximo es de 30 caracteres")]
        [Display(Name = "Fecha y Hora")]
        public string FechaHora {get;set;}
        [Required(ErrorMessage = "Ingrese el marcador")]
        [Range(0, 10, ErrorMessage = "Debe insertar un numero entre 0 y 10")]
        [Display(Name = "Marcador")]
        public int Marcador {get;set;}

        public Arbitro Arbitro {get;set;}

        public Equipo EquipoLocal {get;set;}

        public Equipo EquipoVisitante {get;set;}

        public Estadio Estadio {get;set;}
    }
}