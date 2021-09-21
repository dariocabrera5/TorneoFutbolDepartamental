using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public abstract class Partido
    {
        private Arbitro _arbitro;
        private Equipo _equipo;
        private Estadio _estadio;

        public Partido(int id, string FechaHora, int marcador, string esquipo, string estadio, string arbitro)
        {
            _arbitro = new Arbitro();
            _equipo = new Equipo();
            _Estadio = new Estadio();
        }

        public void AgregarArbitro(int Id, string ColegioPertenece)
        {
            Arbitro arbitro = new Arbitro(Id, ColegioPertenece);
            _arbitro.Add(arbitro);
        }

        public void AgregarEquipo(int Id, string Nombre, string Municipio, string DirectorTecnico, string Jugador, int CntPartidosJugados, int CntPartidosGanados, int CntPartidosEmpatados, int GolesFavor, int GolesContra, int Puntos)
        {
            Equipo equipo = new Equipo(Id, Nombre, Municipio, DirectorTecnico, Jugador, CntPartidosJugados, CntPartidosGanados, CntPartidosEmpatados, GolesFavor, GolesContra, Puntos);
            _equipo.Add(equipo);
        }

        public void AgregarEstadio(int Id, string Nombre, string Direccion, string Ciudad, string Municipio)
        {
            Estadio estadio = new Estadio(Id, Nombre, Direccion, Ciudad, Municipio);
            _estadio.Add(estadio);
        }

        public int Id { get; set; }
        public string FechaHora { get; set; }
        public int marcador { get; set; }
        public string Equipo { get; set; }
        public string Estadio { get; set; }
        public string Arbitro { get; set; }
    }
}