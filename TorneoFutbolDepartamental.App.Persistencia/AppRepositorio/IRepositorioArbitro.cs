using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia.AppRepositorio
{
    public class IRepositorioArbitro
    {

         IEnumerable<Arbitro> ObtenerArbitros();

         Arbitro AñadirArbitro(Arbitro arbitro);

         Arbitro ActualizarArbitro(Arbitro arbitro);

         void BorrarArbitro(int idArbitro);

         Arbitro ObtenerArbitro(int idArbitro);

    }
}