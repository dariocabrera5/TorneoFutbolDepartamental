using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public class Equipo
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public int cntPartidosEmpatados {get;set;}
        public int cntPartidosGanados {get;set;}
        public int cntPartidosJugados {get;set;}
        public int GolesContra {get;set;}
        public int GolesFavor{get;set;}
        public int Puntos{get;set;}
        public DirectorTecnico DirectorTecnico {get;set;}
        public Municipio municipio {get;set;}  
    }
}