using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioDirectorTecnico {
        DirectorTecnico AddDirectorTecnico (DirectorTecnico directortecnico);
    }
}