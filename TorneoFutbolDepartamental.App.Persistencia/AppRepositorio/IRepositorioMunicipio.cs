using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        IEnumerable<Municipio> GetAllMunicipios();

        Municipio AddMunicipio(Municipio municipio);

        Municipio UpdateMunicipio(Municipio municipio);

        void DeleteMunicipio(int Municipioid);

        Municipio GetMunicipio(int Municipioid);
    }
}