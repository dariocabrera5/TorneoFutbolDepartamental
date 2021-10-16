using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDepartamental.App.Dominio
{
    public class Equipo
    {
        public int EquipoId {get;set;}
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "El maximo es de 20 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre {get;set;}
        [Required(ErrorMessage = "Ingrese los partidos empatados")]
        [Range(0, 25, ErrorMessage = "Debe insertar un numero entre 0 y 25")]
        [Display(Name = "Partidos Empatados")]
        public int Cnt_PartidosEmpatados {get;set;}
        [Required(ErrorMessage = "Ingrese los partidos ganados")]
        [Range(0, 25, ErrorMessage = "Debe insertar un numero entre 0 y 25")]
        [Display(Name = "Partidos Ganados")]
        public int Cnt_PartidosGanados {get;set;}
        [Required(ErrorMessage = "Ingrese los partidos jugados")]
        [Range(0, 25, ErrorMessage = "Debe insertar un numero entre 0 y 25")]
        [Display(Name = "Partidos Jugados")]
        public int Cnt_PartidosJugados {get;set;}
        [Required(ErrorMessage = "Ingrese los goles que recibio el equipo")]
        [Range(0, 100, ErrorMessage = "Debe insertar un numero entre 0 y 100")]
        [Display(Name = "Goles Contra")]
        public int GolesContra {get;set;}
        [Required(ErrorMessage = "Ingrese los goles echos por el equipo")]
        [Range(0, 100, ErrorMessage = "Debe insertar un numero entre 0 y 100")]
        [Display(Name = "Goles Favor")]
        public int GolesFavor{get;set;}
        [Required(ErrorMessage = "Ingrese los puntos ganados")]
        [Range(0, 75, ErrorMessage = "Debe insertar un numero entre 0 y 75")]
        [Display(Name = "Puntos")]
        public int Puntos{get;set;}
        public Jugador Jugador {get;set;}
        public DirectorTecnico DirectorTecnico {get;set;}
        public Municipio Municipio {get;set;}
    }
}