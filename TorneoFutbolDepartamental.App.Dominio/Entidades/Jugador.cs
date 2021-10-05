using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public class Jugador : Persona
    {
        public int JugadorId { get; set; }

        public int Numero { get; set; }

        public string Posicion { get; set; }
        
        public string Equipo { get; set; }
    }
}