using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDepartamental.App.Dominio
{
    public class Persona
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El maximo es de 50 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Documento es obligatorio")]
        [StringLength(10, ErrorMessage = "El maximo es de 10 caracteres")]
        [Display(Name = "Documento")]
        public string Documento { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio")]
        [StringLength(10, ErrorMessage = "El maximo es de 10 caracteres")]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
    }
}