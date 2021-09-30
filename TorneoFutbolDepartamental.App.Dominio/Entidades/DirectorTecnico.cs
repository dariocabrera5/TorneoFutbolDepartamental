using System;
namespace TorneoFutbolDepartamental.App.Dominio
{
    public class DirectorTecnico : Persona
    {
        public int Id { get; set; }
        public int EquipoForeignKey { get; set; }
        public Equipo Equipo { get; set; }
    }
}