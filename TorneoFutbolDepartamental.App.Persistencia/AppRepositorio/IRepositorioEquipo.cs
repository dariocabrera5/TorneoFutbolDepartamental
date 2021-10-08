using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioEquipo
    {
         IEnumerable<Equipo> GetAllEquipos();

         Equipo AddEquipo(Equipo equipo);

         Equipo UpdateEquipo(Equipo equipo);

         void DeleteEquipo(int Equipoid);

         Equipo GetEquipo(int Equipoid);
    }
}