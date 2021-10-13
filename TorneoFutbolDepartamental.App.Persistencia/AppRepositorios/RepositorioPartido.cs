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
            return _appContext.Partidos.FirstOrDefault(p => p.PartidoId == Partidoid);
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
    }
}