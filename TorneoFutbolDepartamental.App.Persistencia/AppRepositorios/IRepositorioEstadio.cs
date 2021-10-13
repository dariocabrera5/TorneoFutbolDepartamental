using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
<<<<<<< HEAD
    public interface IRepositorioEstadio {
        Estadio AddEstadio (Estadio estadio);
        IEnumerable<Estadio> GetAllEstadios(); 
        void DeleteEstadio(int idEstadio);
        public Estadio GetEstadio(int idEstadio);
        Estadio UpdateEstadio(Estadio estadioActualizado);
        //public Estadio UpdateEstadio(Estadio estadio);

=======
    public interface IRepositorioEstadio
    {
        IEnumerable<Estadio> GetAllEstadios();

        Estadio AddEstadio(Estadio estadio);

        Estadio UpdateEstadio(Estadio estadio);

        void DeleteEstadio(int Estadioid);

        Estadio GetEstadio(int Estadioid);
>>>>>>> 93787db8daafa996e8308e6a8691930127ebdc74
    }
}