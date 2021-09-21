using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public abstract class Equipo
    {
        private Jugador _jugador;
        private DirectorTecnico _director;
        private Municipio _municipio;

        public Equipo(int Id, string Nombre, string Municipio, string DirectorTecnico, string Jugador, int CntPartidosJugados, int CntPartidosGanados, int CntPartidosEmpatados, int GolesFavor, int GolesContra, int Puntos)
        {
            _jugador = new Jugador();
            _director = new DirectorTecnico();
            _municipio = new Municipio();
        }

        public void AgregarJugador(int Id, int Numero, string Posicion, string Equipo)
        {
            Jugador jugador = new Jugador(Id, Numero, Posicion, Equipo);
            _jugador.Add(jugador);
        }

        public void AgregarDirectorTecnico(int Id, string Equipo)
        {
            DirectorTecnico director = new DirectorTecnico(Id, Equipo);
            _director.Add(director);
        }

        public void AgregarMunicipio(int Id, string Nombre)
        {
            Municipio municipio = new Municipio(Id, Nombre);
            _municipio.Add(municipio);
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Municipio { get; set; }
        public string DirectorTecnico { get; set; }
        public string Jugador { get; set; }
        public int CntPartidosJugados { get; set; }
        public int CntPartidosGanados { get; set; }
        public int CntPartidosEmpatados { get; set; }
        public int GolesFavor { get; set; }
        public int GolesContra { get; set; }
        public int Puntos { get; set; }
    }   
}