using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();

        Estadio IRepositorioEstadio.AddEstadio (Estadio estadio)
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        }
        IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadios()
        {   
            return _appContext.Estadios;
        }
         public void DeleteEstadio(int idEstadio)
        {
            var EstadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (EstadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(EstadioEncontrado);
            _appContext.SaveChanges();
        }
        public Estadio GetEstadio(int idEstadio)
        {
            return _appContext.Estadios.Find(idEstadio);
        }
        public Estadio UpdateEstadio(Estadio estadio)
        {
            var EstadioEncontrado = _appContext.Estadios.Find(estadio.Id);
            if (EstadioEncontrado != null)
            {
                EstadioEncontrado.Nombre = estadio.Nombre;
                EstadioEncontrado.Direccion = estadio.Direccion;
                EstadioEncontrado.Municipio = estadio.Municipio;
                _appContext.SaveChanges();
            }
            return EstadioEncontrado;
        }

    }
}
