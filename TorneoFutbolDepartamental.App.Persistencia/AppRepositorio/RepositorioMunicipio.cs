using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioMunicipio (AppContext appContext)
        {
            _appContext=appContext;
        }

        Municipio IRepositorioMunicipio.AñadirMunicipio (Municipio municipio)
        {
            var MunicipioAñadido = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return MunicipioAñadido.Entity;
        }
        
        void IRepositorioMunicipio.BorrarMunicipio (int Municipioid)
        {
            var MunicipioEncontrado = _appContext.Municipio.FirstOrDefault(m => m.MunicipioId == Municipioid);
            if (Municipiocontrado == null)
                return;
            _appContext.Municipio.Remove(MunicipioEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Municipio> IRepositorioMunicipio.ObtenerMunicipios ()
        {
            return _appContext.Municipios;
        }

        Municipio IRepositorioMunicipio.ObtenerMunicipio (int Municipioid)
        {
            return _appContext.Municipio.FirstOrDefault(m => m.MunicipioId == Municipioid);
        }

        Municipio IRepositorioMunicipio.ActualizarMunicipio (Municipio municipio)
        {
            var MunicipioEncontrado = _appContext.Municipio.FirstOrDefault(m => m.MunicipioId == municipio.MunicipioId);
            if (MunicipioEncontrado != null)
            {
                MunicipioEncontrado.Nombre = municipio.Nombre;

                _appContext.SaveChanges();
                
            }
            return MunicipioEncontrado;
        }
    }
}