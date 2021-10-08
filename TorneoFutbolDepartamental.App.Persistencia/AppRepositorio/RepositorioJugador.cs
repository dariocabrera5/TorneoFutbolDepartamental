using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
         private readonly AppContext _appContext = new AppContext();

        public RepositorioJugador()
        {
        }

        public RepositorioJugador (AppContext appContext)
        {
            _appContext=appContext;
        }

        Jugador IRepositorioJugador.AddJugador (Jugador jugador)
        {
            var JugadorAñadido = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return JugadorAñadido.Entity;
        }
        
        void IRepositorioJugador.DeleteJugador (int Jugadorid)
        {
            var JugadorEncontrado= _appContext.Jugadores.FirstOrDefault(j => j.JugadorId == Jugadorid);
            if (JugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(JugadorEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Jugador> IRepositorioJugador.GetAllJugadores ()
        {
            return _appContext.Jugadores;
        }

        Jugador IRepositorioJugador.GetJugador (int Jugadorid)
        {
            return _appContext.Jugadores.FirstOrDefault(j => j.JugadorId == Jugadorid);
        }

        Jugador IRepositorioJugador.UpdateJugador (Jugador jugador)
        {
            var JugadorEncontrado = _appContext.Jugadores.FirstOrDefault(j => j.JugadorId == jugador.JugadorId);
            if (JugadorEncontrado != null)
            {
                JugadorEncontrado.Nombre = jugador.Nombre;
                JugadorEncontrado.Documento = jugador.Documento;
                JugadorEncontrado.Telefono = jugador.Telefono;
                JugadorEncontrado.Numero = jugador.Numero;
                JugadorEncontrado.Posicion = jugador.Posicion;
                JugadorEncontrado.Equipo = jugador.Equipo;

                _appContext.SaveChanges();
                
            }
            return JugadorEncontrado;
        }
    }
}