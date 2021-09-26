using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public class Jugador : Persona
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Posicion { get; set; }
        public Equipo Equipo { get; set; }
    }
}