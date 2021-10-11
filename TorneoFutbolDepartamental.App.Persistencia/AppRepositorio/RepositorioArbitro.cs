using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioArbitro()
        {
        }

        public RepositorioArbitro (AppContext appContext)
        {
            _appContext=appContext;
        }

        Arbitro IRepositorioArbitro.AddArbitro (Arbitro arbitro)
        {
            var ArbitroAñadido = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return ArbitroAñadido.Entity;
        }
        void IRepositorioArbitro.DeleteArbitro (int Arbitroid)
        {
            var ArbitroEncontrado = _appContext.Arbitros.FirstOrDefault(a => a.ArbitroId == Arbitroid);
            if (ArbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(ArbitroEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Arbitro> IRepositorioArbitro.GetAllArbitros ()
        {
            return _appContext.Arbitros;
        }

        Arbitro IRepositorioArbitro.GetArbitro (int Arbitroid)
        {
            return _appContext.Arbitros.FirstOrDefault(a => a.ArbitroId == Arbitroid);
        }

        Arbitro IRepositorioArbitro.UpdateArbitro (Arbitro arbitro)
        {
            var ArbitroEncontrado = _appContext.Arbitros.FirstOrDefault(j => j.ArbitroId == arbitro.ArbitroId);
            if (ArbitroEncontrado != null)
            {
                ArbitroEncontrado.Nombre = arbitro.Nombre;
                ArbitroEncontrado.Documento = arbitro.Documento;
                ArbitroEncontrado.Telefono = arbitro.Telefono;
                ArbitroEncontrado.ColegioPertenece = arbitro.ColegioPertenece;

                _appContext.SaveChanges();
            }
            return ArbitroEncontrado;
        }
    }
}