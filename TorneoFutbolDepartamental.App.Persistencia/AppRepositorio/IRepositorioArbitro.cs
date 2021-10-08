using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioArbitro
    {

         IEnumerable<Arbitro> ObtenerArbitros();

         Arbitro AñadirArbitro(Arbitro arbitro);

         Arbitro ActualizarArbitro(Arbitro arbitro);

         void BorrarArbitro(int Arbitroid);

         Arbitro ObtenerArbitro(int Arbitroid);

    }
}