using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
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
        
        void IRepositorioDirectorTecnico.BorrarDirectorTecnico (int DirectorTecnicoid)
        {
            var DirectorTecnicoEncontrado = _appContext.DirectorTecnico.FirstOrDefault(dt => dt.DirectorTecnicoId == DirectorTecnicoid);
            if (DirectorTecnicoEncontrado == null)
                return;
            _appContext.DirectorTecnico.Remove(DirectorTecnicoEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.ObtenerDirectoresTecnicos ()
        {
            return _appContext.DirectoresTecnicos;
        }

        DirectorTecnico IRepositorioDirectorTecnico.ObtenerDirectorTecnico (int DirectorTecnicoid)
        {
            return _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.DirectorTecnicoId == DirectorTecnicoid);
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