using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioEquipo()
        {
        }

        public RepositorioEquipo (AppContext appContext)
        {
            _appContext=appContext;
        }

        DirectorTecnico IRepositorioEquipo.AsignarDirectorTecnico(int Equipoid, int DirectorTecnicoid)
        {
            var equipoEncontrado = _appContext.Equipos.Find(Equipoid);
            if(equipoEncontrado != null)
            {
                var directorTecnicoEncontrado = _appContext.DirectoresTecnicos.Find(DirectorTecnicoid);
                if(directorTecnicoEncontrado != null)
                {
                    equipoEncontrado.DirectorTecnico = directorTecnicoEncontrado;
                    _appContext.SaveChanges();
                }
                return directorTecnicoEncontrado;
            }
            return null;
        }

        Municipio IRepositorioEquipo.AsignarMunicipio(int Equipoid, int Municipioid)
        {
            var equipoEncontrado = _appContext.Equipos.Find(Equipoid);
            if(equipoEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.Find(Municipioid);
                if(municipioEncontrado != null)
                {
                    equipoEncontrado.Municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

        Equipo IRepositorioEquipo.AddEquipo (Equipo equipo)
        {
            var EquipoAñadido = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return EquipoAñadido.Entity;
        }
        void IRepositorioEquipo.DeleteEquipo (int Equipoid)
        {
            var EquipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.EquipoId == Equipoid);
            if (EquipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(EquipoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Equipo> IRepositorioEquipo.GetAllEquipos ()
        {
            return _appContext.Equipos;
        }

        Equipo IRepositorioEquipo.GetEquipo (int Equipoid)
        {
            var equipo = _appContext.Equipos.Where(e => e.EquipoId == Equipoid).Include(e => e.DirectorTecnico).Include(e => e.Municipio).FirstOrDefault();
            return equipo;
        }

        Equipo IRepositorioEquipo.UpdateEquipo (Equipo equipo)
        {
            var EquipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.EquipoId == equipo.EquipoId);
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