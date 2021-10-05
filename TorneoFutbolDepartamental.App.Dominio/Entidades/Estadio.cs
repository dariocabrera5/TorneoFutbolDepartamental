using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public class Estadio
    {
        public int EstadioId {get;set;}

        public string Nombre {get;set;}

        public string Direccion {get;set;}

        public string Ciudad {get;set;}
        
        public Municipio Municipio {get;set;}
    }
}