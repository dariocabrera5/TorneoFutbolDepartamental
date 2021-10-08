using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioPartido
    {
        IEnumerable<Partido> ObtenerPartidos();

        Partido AñadirPartido(Partido partido);

        Partido ActualizarPartido(Partido partido);

        void BorrarPartido(int Partidoid);

        Partido ObtenerPartido(int Partidoid);
    }
}