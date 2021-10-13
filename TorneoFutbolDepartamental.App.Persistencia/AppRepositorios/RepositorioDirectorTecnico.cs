using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioDirectorTecnico()
        {
        }

        public RepositorioDirectorTecnico(AppContext appContext) => _appContext = appContext;

        DirectorTecnico IRepositorioDirectorTecnico.AddDirectorTecnico (DirectorTecnico directorTecnico)
        {
            var DirectorTecnicoAñadido = _appContext.DirectoresTecnicos.Add(directorTecnico);
            _appContext.SaveChanges();
            return DirectorTecnicoAñadido.Entity;
        }
        
        void IRepositorioDirectorTecnico.DeleteDirectorTecnico (int DirectorTecnicoid)
        {
            var DirectorTecnicoEncontrado = _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.DirectorTecnicoId == DirectorTecnicoid);
            if (DirectorTecnicoEncontrado == null)
                return;
            _appContext.DirectoresTecnicos.Remove(DirectorTecnicoEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.GetAllDirectoresTecnicos ()
        {
            return _appContext.DirectoresTecnicos;
        }

        DirectorTecnico IRepositorioDirectorTecnico.GetDirectorTecnico (int DirectorTecnicoid)
        {
            return _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.DirectorTecnicoId == DirectorTecnicoid);
        }

        DirectorTecnico IRepositorioDirectorTecnico.UpdateDirectorTecnico (DirectorTecnico directorTecnico)
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