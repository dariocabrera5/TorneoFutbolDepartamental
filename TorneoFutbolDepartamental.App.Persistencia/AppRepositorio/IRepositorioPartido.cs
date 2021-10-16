using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioPartido
    {
        IEnumerable<Partido> GetAllPartidos();

        Partido AddPartido(Partido partido);

        Partido UpdatePartido(Partido partido);

        void DeletePartido(int Partidoid);

        Partido GetPartido(int Partidoid);

        Arbitro AsignarArbitro(int Partidoid, int Arbitroid);

        Equipo AsignarEquipoLocal(int Partidoid, int Equipoid);

        Equipo AsignarEquipoVisitante(int Partidoid, int Equipoid);

        Estadio AsignarEstadio(int Partidoid, int Estadioid);
    }
}