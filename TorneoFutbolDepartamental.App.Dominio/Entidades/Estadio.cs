using System;
namespace TorneoFutbolDepartamental.App.Dominio
{  
    public abstract class Estadio
    {
        private Municipio _municipio;

        public Estadio(int Id, string Nombre, string Direccion, string Ciudad, string Municipio)
        {
            _municipio = new Municipio();
        }
        
        public void AgregarMunicipio(int Id, string Nombre)
        {
            Municipio municipio = new Municipio(Id, Nombre);
            _municipio.Add(municipio);
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Municipio { get; set; }
    }
}