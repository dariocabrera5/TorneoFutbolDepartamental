using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioMunicipio()
        {
        }

        public RepositorioMunicipio (AppContext appContext)
        {
            _appContext=appContext;
        }

        Municipio IRepositorioMunicipio.AddMunicipio (Municipio municipio)
        {
            var MunicipioAñadido = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return MunicipioAñadido.Entity;
        }
        
        void IRepositorioMunicipio.DeleteMunicipio (int Municipioid)
        {
            var MunicipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.MunicipioId == Municipioid);
            if (MunicipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(MunicipioEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipios ()
        {
            return _appContext.Municipios;
        }

        Municipio IRepositorioMunicipio.GetMunicipio (int Municipioid)
        {
            return _appContext.Municipios.FirstOrDefault(m => m.MunicipioId == Municipioid);
        }

        Municipio IRepositorioMunicipio.UpdateMunicipio (Municipio municipio)
        {
            var MunicipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.MunicipioId == municipio.MunicipioId);
            if (MunicipioEncontrado != null)
            {
                MunicipioEncontrado.Nombre = municipio.Nombre;

                _appContext.SaveChanges();
                
            }
            return MunicipioEncontrado;
        }
    }
}