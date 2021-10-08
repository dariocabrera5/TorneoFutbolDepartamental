using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
         
         IEnumerable<DirectorTecnico> ObtenerDirectoresTecnicos();

         DirectorTecnico AñadirDirectorTecnico(DirectorTecnico directorTecnico);

         DirectorTecnico ActualizarDirectorTecnico(DirectorTecnico directorTecnico);

         void BorrarDirectorTecnico(int DirectorTecnicoid);

         DirectorTecnico ObtenerDirectorTecnico(int DirectorTecnicoid);

    }
}