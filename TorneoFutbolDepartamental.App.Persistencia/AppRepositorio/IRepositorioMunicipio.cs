using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        IEnumerable<Municipio> ObtenerMunicipios();

        Municipio AñadirMunicipio(Municipio municipio);

        Municipio ActualizarMunicipio(Municipio municipio);

        void BorrarMunicipio(int Municipioid);

        Municipio ObtenerMunicipio(int Municipioid);
    }
}