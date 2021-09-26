using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioMunicipio {
        Municipio AddMunicipio (Municipio municipio);
    }
}