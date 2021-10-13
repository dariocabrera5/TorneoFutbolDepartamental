using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public class Partido
    {
        public int PartidoId {get;set;}
        public string FechaHora {get;set;}
<<<<<<< HEAD
        public int marcadorEquipoLocal {get;set;}
        public int maracadorEquipoVisitante {get;set;}
=======

        public int Marcador {get;set;}

>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74
        public Arbitro Arbitro {get;set;}

        public Equipo EquipoLocal {get;set;}

        public Equipo EquipoVisitante {get;set;}

        public Estadio Estadio {get;set;}
    }
}