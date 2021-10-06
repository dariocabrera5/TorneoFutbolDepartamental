using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia.AppRepositorio
{
    public interface IRepositorioDirectorTecnico
    {
         
         IEnumerable<DirectorTecnico> ObtenerDirectoresTecnicos();

         DirectorTecnico AñadirDirectorTecnico(DirectorTecnico directorTecnico);

         DirectorTecnico ActualizarDirectorTecnico(DirectorTecnico directorTecnico);

         void BorrarDirectorTecnico(int idDirectorTecnico);

         DirectorTecnico ObtenerDirectorTecnico(int idDirectorTecnico);

    }
}