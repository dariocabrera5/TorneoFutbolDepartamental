using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioArbitro
    {

         IEnumerable<Arbitro> GetAllArbitros();

         Arbitro AddArbitro(Arbitro arbitro);

         Arbitro UpdateArbitro(Arbitro arbitro);

         void DeleteArbitro(int Arbitroid);

         Arbitro GetArbitro(int Arbitroid);

    }
}