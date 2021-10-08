using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioJugador
    {
         IEnumerable<Jugador> ObtenerJugadores();

         Jugador AñadirJugador(Jugador jugador);

         Jugador ActualizarJugador(Jugador jugador);

         void BorrarJugador(int Jugadorid);

         Jugador ObtenerJugador(int Jugadorid);
    }
}