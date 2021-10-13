using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        IEnumerable<Estadio> GetAllEstadios();

        Estadio AddEstadio(Estadio estadio);

        Estadio UpdateEstadio(Estadio estadio);

        void DeleteEstadio(int Estadioid);

        Estadio GetEstadio(int Estadioid);
    }
}