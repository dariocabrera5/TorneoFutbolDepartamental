using System;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;
namespace TorneoFutbolDepartamental.App.Consola
{
    class Program
    {
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio();
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddArbitro();
            //AddDirectorTecnico();
            //AddMunicipio();
            //AddEquipo();
            //AddJugador();
            AddEstadio();
            //AddPartido();
        }
        private static void AddJugador(){
            var Jugador =new Jugador{
                Nombre = "Luis",
                Documento = "10383795",
                Telefono = "313789732",
                Numero = 10,
                Posicion = "delantero",
            };
            _repoJugador.AddJugador(Jugador);
        }
        private static void AddMunicipio(){
            var Municipio =new Municipio{
                Nombre = "Samaniego",
            };
            _repoMunicipio.AddMunicipio(Municipio);
        }
        private static void AddDirectorTecnico(){
            var DirectorTecnico =new DirectorTecnico{
                Nombre = "carlo ancelotti",
                Documento = "6666666",
                Telefono = "3112355455",
                EquipoForeignKey = 3,
            };
            _repoDirectorTecnico.AddDirectorTecnico(DirectorTecnico);
        }
        private static void AddEquipo(){
            var Equipo =new Equipo{
                Nombre = "Real Madrid FC",
                cntPartidosEmpatados = 2,
                cntPartidosGanados = 1,
                cntPartidosJugados = 3,
                GolesFavor = 4,
                GolesContra = 5,
                Puntos = 5,
            };
            _repoEquipo.AddEquipo(Equipo);
        }
            private static void AddEstadio(){
            var Estadio =new Estadio{
                Nombre = "campin",
                Direccion = "calle100b-#8527",
            };
            _repoEstadio.AddEstadio(Estadio);
        }
        private static void AddPartido(){
            var Partido =new Partido{
                FechaHora = "12-sep-2021/13:00",
                marcadorEquipoLocal = 1,
                maracadorEquipoVisitante =2,
            };
            _repoPartido.AddPartido(Partido);
        }
         private static void AddArbitro(){
            var newArbitro =new Arbitro{
                Nombre = "Rafael",
                Documento = "44444444",
                Telefono = "3154444432",
                ColegioPertenece = "bbbb"
            };
            _repoArbitro.AddArbitro(newArbitro);
        }
    }
}
