using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioEquipo (AppContext appContext)
        {
            _appContext=appContext;
        }

        Equipo IRepositorioEquipo.AñadirEquipo (Equipo equipo)
        {
            var EquipoAñadido = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return EquipoAñadido.Entity;
        }
        
        void IRepositorioEquipo.BorrarEquipo (int Equipoid)
        {
            var EquipoEncontrado = _appContext.Equipo.FirstOrDefault(e => e.EquipoId == Equipoid);
            if (EquipoEncontrado == null)
                return;
            _appContext.Equipo.Remove(EquipoEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Equipo> IRepositorioEquipo.ObtenerEquipos ()
        {
            return _appContext.Equipos;
        }

        Equipo IRepositorioEquipo.ObtenerEquipo (int Equipoid)
        {
            return _appContext.Equipos.FirstOrDefault(e => e.EquipoId == Equipoid);
        }

        Equipo IRepositorioEquipo.ActualizarEquipo (Equipo equipo)
        {
            var EquipoEncontrado = _appContext.Equipo.FirstOrDefault(e => e.EquipoId == equipo.EquipoId);
            if (EquipoEncontrado != null)
            {
                EquipoEncontrado.Nombre = equipo.Nombre;
                EquipoEncontrado.Cnt_PartidosEmpatados = equipo.Cnt_PartidosEmpatados;
                EquipoEncontrado.Cnt_PartidosGanados = equipo.Cnt_PartidosGanados;
                EquipoEncontrado.Cnt_PartidosJugados = equipo.Cnt_PartidosJugados;
                EquipoEncontrado.GolesContra = equipo.GolesContra;
                EquipoEncontrado.GolesFavor = equipo.GolesFavor;
                EquipoEncontrado.Puntos = equipo.Puntos;
                EquipoEncontrado.Jugador = equipo.Jugador;
                EquipoEncontrado.DirectorTecnico = equipo.DirectorTecnico;
                EquipoEncontrado.Municipio = equipo.Municipio;

                _appContext.SaveChanges();
                
            }
            return EquipoEncontrado;
        }
    }
}