using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        IEnumerable<Estadio> ObtenerEstadios();

        Estadio AñadirEstadio(Estadio estadio);

        Estadio ActualizarEstadio(Estadio estadio);

        void BorrarEstadio(int Estadioid);

        Estadio ObtenerEstadio(int Estadioid);
    }
}