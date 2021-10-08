using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioEstadio (AppContext appContext)
        {
            _appContext=appContext;
        }

        Estadio IRepositorioEstadio.AñadirEstadio (Estadio estadio)
        {
            var EstadioAñadido = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return EstadioAñadido.Entity;
        }
        
        void IRepositorioEstadio.BorrarEstadio (int idEstadio)
        {
            var EstadioEncontrado = _appContext.Estadio.FirstOrDefault(es => es.EstadioId == Estadioid);
            if (EstadioEncontrado == null)
                return;
            _appContext.Estadio.Remove(EstadioEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Estadio> IRepositorioEstadio.ObtenerEstadios ()
        {
            return _appContext.Estadios;
        }

        Estadio IRepositorioEstadio.ObtenerEstadio (int Estadioid)
        {
            return _appContext.Estadios.FirstOrDefault(es => es.EstadioId == Estadioid);
        }

        Estadio IRepositorioEstadio.ActualizarEstadio (Estadio estadio)
        {
            var EstadioEncontrado = _appContext.Estadio.FirstOrDefault(es=> es.EstadioId == estadio.EstadioId);
            if (EstadioEncontrado != null)
            {
                EstadioEncontrado.Nombre = estadio.Nombre;
                EstadioEncontrado.Direccion = estadio.Direccion;
                EstadioEncontrado.Ciudad = estadio.Ciudad;
                EstadioEncontrado.Municipio = estadio.Municipio;

                _appContext.SaveChanges();
                
            }
            return EstadioEncontrado;
        }
    }
}