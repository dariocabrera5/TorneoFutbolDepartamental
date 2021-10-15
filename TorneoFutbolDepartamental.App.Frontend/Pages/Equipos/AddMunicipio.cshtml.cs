using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.Pages.Equipos
{
    public class AddMunicipioModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Equipo equipo {get;set;}
        public IEnumerable<Municipio> municipios {get;set;}
        public AddMunicipioModel(IRepositorioEquipo repoEquipo, IRepositorioMunicipio repoMunicipio)
        {
            _repoEquipo = repoEquipo;
            _repoMunicipio = repoMunicipio;
        }
        public void OnGet(int Equipoid)
        {
            equipo = _repoEquipo.GetEquipo(Equipoid);
            municipios = _repoMunicipio.GetAllMunicipios();
        }

        public IActionResult OnPost(int Equipoid, int Municipioid)
        {
            _repoEquipo.AsignarMunicipio(Equipoid, Municipioid);
            return RedirectToPage("Details", new{Equipoid = Equipoid});
        }
    }
}
