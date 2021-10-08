using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioJugador
    {
         IEnumerable<Jugador> GetAllJugadores();

         Jugador AddJugador(Jugador jugador);

         Jugador UpdateJugador(Jugador jugador);

         void DeleteJugador(int Jugadorid);

         Jugador GetJugador(int Jugadorid);
    }
}