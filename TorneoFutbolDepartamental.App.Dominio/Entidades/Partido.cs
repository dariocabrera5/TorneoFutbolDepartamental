using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public class Partido
    {
        public int PartidoId {get;set;}
        public string FechaHora {get;set;}

        public int Marcador {get;set;}

        public Arbitro Arbitro {get;set;}

        public Equipo EquipoLocal {get;set;}

        public Equipo EquipoVisitante {get;set;}

        public Estadio Estadio {get;set;}
    }
}