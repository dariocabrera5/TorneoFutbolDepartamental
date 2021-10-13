using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
         
         IEnumerable<DirectorTecnico> GetAllDirectoresTecnicos();

         DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);

         DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directorTecnico);

         void DeleteDirectorTecnico(int DirectorTecnicoid);

         DirectorTecnico GetDirectorTecnico(int DirectorTecnicoid);

    }
}