using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();

        Arbitro IRepositorioArbitro.AddArbitro (Arbitro arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }
    }
}