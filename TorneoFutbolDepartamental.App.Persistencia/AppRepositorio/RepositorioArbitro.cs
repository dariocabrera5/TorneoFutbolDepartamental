using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia.AppRepositorio
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioArbitro (AppContext appContext)
        {
            _appContext=appContext;
        }

        Arbitro IRepositorioArbitro.AñadirArbitro (Arbitro arbitro)
        {
            var ArbitroAñadido = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return ArbitroAñadido.Entity;
        }
        
        void IRepositorioArbitro.BorrarArbitro (int idArbitro)
        {
            var ArbitroEncontrado = _appContext.Arbitros.FirstOrDefault(a => a.ArbitroId == idArbitro);
            if (ArbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(ArbitroEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Arbitro> IRepositorioArbitro.ObtenerArbitros ()
        {
            return _appContext.Arbitros;
        }

        Arbitro IRepositorioArbitro.ObtenerArbitro (int idArbitro)
        {
            return _appContext.Arbitros.FirstOrDefault(a => a.ArbitroId == idArbitro);
        }

        Arbitro IRepositorioArbitro.ActualizarArbitro (Arbitro arbitro)
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