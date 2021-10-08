using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioEquipo
    {
         IEnumerable<Equipo> ObtenerEquipos();

         Equipo AñadirEquipo(Equipo equipo);

         Equipo ActualizarEquipo(Equipo equipo);

         void BorrarEquipo(int Equipoid);

         Equipo ObtenerEquipo(int Equipoid);
    }
}