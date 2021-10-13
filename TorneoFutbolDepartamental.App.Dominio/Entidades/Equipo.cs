using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public class Equipo
    {
        public int EquipoId {get;set;}

        public string Nombre {get;set;}

        public int Cnt_PartidosEmpatados {get;set;}

        public int Cnt_PartidosGanados {get;set;}

        public int Cnt_PartidosJugados {get;set;}

        public int GolesContra {get;set;}

        public int GolesFavor{get;set;}

        public int Puntos{get;set;}

        public Jugador Jugador {get;set;}

        public DirectorTecnico DirectorTecnico {get;set;}

        public Municipio Municipio {get;set;}
    }
}