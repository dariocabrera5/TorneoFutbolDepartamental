using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext = new AppContext();

        DirectorTecnico IRepositorioDirectorTecnico.AddDirectorTecnico (DirectorTecnico directortecnico)
        {
            var directortecnicoAdicionado = _appContext.Tecnicos.Add(directortecnico);
            _appContext.SaveChanges();
            return directortecnicoAdicionado.Entity;
        }
    }
}