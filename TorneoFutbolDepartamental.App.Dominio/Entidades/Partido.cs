using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public class Partido
    {
        public int Id {get;set;}
        public string FechaHora {get;set;}
        public int marcadorEquipoLocal {get;set;}
        public int maracadorEquipoVisitante {get;set;}
        public Arbitro Arbitro {get;set;}
        public Equipo EquipoLocal {get;set;}
        public Equipo EquipoVisitante {get;set;}
        public Estadio Estadio {get;set;}
    }
}