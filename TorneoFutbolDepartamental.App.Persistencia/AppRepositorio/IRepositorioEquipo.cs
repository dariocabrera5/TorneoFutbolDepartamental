using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia.AppRepositorio
{
    public interface IRepositorioEquipo
    {
         IEnumerable<Equipo> ObtenerEquipos();

         Equipo AñadirEquipo(Equipo equipo);

         Equipo ActualizarEquipo(Equipo equipo);

         void BorrarEquipo(int idEquipo);

         Equipo ObtenerEquipo(int idEquipo);
    }
}