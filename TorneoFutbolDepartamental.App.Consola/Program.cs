using System;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;
namespace TorneoFutbolDepartamental.App.Consola
{
    class Program
    {
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ObtenerArbitros();
            //CrearDirectorTecnico();
            //CrearEquipo();
            //CrearEstadio();
            //CrearJugador();
            //CrearMunicipio();
            //CrearPartido();
            //BorrarMunicipio();
            //CrearArbitro();
        }

        private static void CrearArbitro(){
            var arbitro =new Arbitro{
                Nombre = "Jose",
                Documento = "1224898795",
                Telefono = "312246832",
                ColegioPertenece = "Liga Nacional"
            };
            _repoArbitro.AddArbitro(arbitro);
        }

        private static void CrearDirectorTecnico(){
            var directorTecnico =new DirectorTecnico{
                Nombre = "Hairo",
                Documento = "10087795",
                Telefono = "32562732",
                Equipo = "Spartacos"
            };
            _repoDirectorTecnico.AddDirectorTecnico(directorTecnico);
        }

        private static void CrearEquipo(){
            var equipo =new Equipo{
                Nombre = "Spartacos",
                Cnt_PartidosEmpatados = 2,
                Cnt_PartidosGanados = 5,
                Cnt_PartidosJugados = 7,
                GolesContra = 3,
                GolesFavor = 10,
                Puntos = 17
            };
            _repoEquipo.AddEquipo(equipo);
        }

        private static void CrearEstadio(){
            var estadio =new Estadio{
                Nombre = "Estadio Las Aguilas",
                Direccion = "Krra 1b calle 13",
                Ciudad = "Bogota"
            };
            _repoEstadio.AddEstadio(estadio);
        }

        private static void CrearJugador(){
            var jugador =new Jugador{
                Nombre = "Diego",
                Documento = "574954315",
                Telefono = "310214896",
                Numero = 15,
                Posicion = "Medio",
                Equipo = "Spartacos"
            };
            _repoJugador.AddJugador(jugador);
        }


        private static void CrearMunicipio(){
            var municipio =new Municipio{
                Nombre = "Mosquera"
            };
            _repoMunicipio.AddMunicipio(municipio);
        }

        private static void CrearPartido(){
            var partido =new Partido{
                FechaHora = "15 / 10 / 2021",
                Marcador = 0
            };
            _repoPartido.AddPartido(partido);
        }

        private static void BorrarMunicipio(){
            _repoMunicipio.DeleteMunicipio(1);
        }

        private static void ObtenerArbitros(){
            _repoArbitro.GetAllArbitros();
        }

    }
}
