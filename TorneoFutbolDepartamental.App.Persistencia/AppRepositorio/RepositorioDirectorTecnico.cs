using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia.AppRepositorio
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositoriDirectorTecnico (AppContext appContext)
        {
            _appContext=appContext;
        }

        DirectorTecnico IRepositorioDirectorTecnico.AñadirDirectorTecnico (DirectorTecnico directorTecnico)
        {
            var DirectorTecnicoAñadido = _appContext.DirectoresTecnicos.Add(directorTecnico);
            _appContext.SaveChanges();
            return DirectorTecnicoAñadido.Entity;
        }
        
        void IRepositorioDirectorTecnico.BorrarDirectorTecnico (int idDirectorTecnico)
        {
            var DirectorTecnicoEncontrado = _appContext.DirectorTecnico.FirstOrDefault(dt => dt.DirectorTecnicoId == idDirectorTecnico);
            if (DirectorTecnicoEncontrado == null)
                return;
            _appContext.DirectorTecnico.Remove(DirectorTecnicoEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.ObtenerDirectoresTecnicos ()
        {
            return _appContext.DirectoresTecnicos;
        }

        DirectorTecnico IRepositorioDirectorTecnico.ObtenerDirectorTecnico (int idDirectorTecnico)
        {
            return _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.DirectorTecnicoId == idDirectorTecnico);
        }

        DirectorTecnico IRepositorioDirectorTecnico.ActualizarDirectorTecnico (DirectorTecnico directorTecnico)
        {
            var DirectorTecnicoEncontrado = _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.DirectorTecnicoId == directorTecnico.DirectorTecnicoId);
            if (DirectorTecnicoEncontrado != null)
            {
                DirectorTecnicoEncontrado.Nombre = directorTecnico.Nombre;
                DirectorTecnicoEncontrado.Documento = directorTecnico.Documento;
                DirectorTecnicoEncontrado.Telefono = directorTecnico.Telefono;
                DirectorTecnicoEncontrado.Equipo = directorTecnico.Equipo;

                _appContext.SaveChanges();
                
            }
            return DirectorTecnicoEncontrado;
        }
    }
}