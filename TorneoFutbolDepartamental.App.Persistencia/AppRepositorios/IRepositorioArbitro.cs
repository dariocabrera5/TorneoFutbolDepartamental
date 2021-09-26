using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioArbitro {
        Arbitro AddArbitro (Arbitro arbitro);
    }
}