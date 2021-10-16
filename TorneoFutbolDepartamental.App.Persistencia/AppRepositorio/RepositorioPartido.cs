using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioPartido()
        {
        }

        public RepositorioPartido (AppContext appContext)
        {
            _appContext=appContext;
        }

        Partido IRepositorioPartido.AddPartido (Partido partido)
        {
            var PartidoAñadido = _appContext.Partidos.Add(partido);
            _appContext.SaveChanges();
            return PartidoAñadido.Entity;
        }
        
        void IRepositorioPartido.DeletePartido (int Partidoid)
        {
            var PartidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.PartidoId == Partidoid);
            if (PartidoEncontrado == null)
                return;
            _appContext.Partidos.Remove(PartidoEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Partido> IRepositorioPartido.GetAllPartidos ()
        {
            return _appContext.Partidos;
        }

        Partido IRepositorioPartido.GetPartido (int Partidoid)
        {
            var partido = _appContext.Partidos.Where(p => p.PartidoId == Partidoid).Include(p => p.Arbitro).Include(p => p.EquipoLocal).Include(p => p.EquipoVisitante).Include(p => p.Estadio).FirstOrDefault();
            return partido;
        }

        Partido IRepositorioPartido.UpdatePartido (Partido partido)
        {
            var PartidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.PartidoId == partido.PartidoId);
            if (PartidoEncontrado != null)
            {
                PartidoEncontrado.FechaHora = partido.FechaHora;
                PartidoEncontrado.Marcador = partido.Marcador;
                PartidoEncontrado.Arbitro = partido.Arbitro;
                PartidoEncontrado.EquipoLocal = partido.EquipoLocal;
                PartidoEncontrado.EquipoVisitante = partido.EquipoVisitante;
                PartidoEncontrado.Estadio = partido.Estadio;

                _appContext.SaveChanges();
            }
            return PartidoEncontrado;
        }

        Arbitro IRepositorioPartido.AsignarArbitro(int Partidoid, int Arbitroid)
        {
            var partidoEncontrado = _appContext.Partidos.Find(Partidoid);
            if (partidoEncontrado != null)
            {
                var arbitroEncontrado = _appContext.Arbitros.Find(Arbitroid);
                if (arbitroEncontrado != null)
                {
                    partidoEncontrado.Arbitro = arbitroEncontrado;
                    _appContext.SaveChanges();
                }
                return arbitroEncontrado;
            }
            return null;
        }

        Equipo IRepositorioPartido.AsignarEquipoLocal(int Partidoid, int Equipoid)
        {
            var partidoEncontrado = _appContext.Partidos.Find(Partidoid);
            if (partidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.Find(Equipoid);
                if (equipoEncontrado != null)
                {
                    partidoEncontrado.EquipoLocal = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

        Equipo IRepositorioPartido.AsignarEquipoVisitante(int Partidoid, int Equipoid)
        {
            var partidoEncontrado = _appContext.Partidos.Find(Partidoid);
            if (partidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.Find(Equipoid);
                if (equipoEncontrado != null)
                {
                    partidoEncontrado.EquipoVisitante = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

        Estadio IRepositorioPartido.AsignarEstadio(int Partidoid, int Estadioid)
        {
            var partidoEncontrado = _appContext.Partidos.Find(Partidoid);
            if (partidoEncontrado != null)
            {
                var estadioEncontrado = _appContext.Estadios.Find(Estadioid);
                if (estadioEncontrado != null)
                {
                    partidoEncontrado.Estadio = estadioEncontrado;
                    _appContext.SaveChanges();
                }
                return estadioEncontrado;
            }
            return null;
        }
    }
}