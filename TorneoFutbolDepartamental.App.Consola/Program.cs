using System;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;
namespace TorneoFutbolDepartamental.App.Consola
{
    class Program
    {
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddArbitro();
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
         private static void AddArbitro(){
            var newArbitro =new Arbitro{
                Nombre = "Luis",
                Documento = "10383795",
                Telefono = "313789732",
                ColegioPertenece = "jfslkdf"
            };
            _repoArbitro.AddArbitro(newArbitro);
        }
    }
}
