using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.Pages.Estadios
{
    public class AddMunicipioModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Estadio estadio {get;set;}
        public IEnumerable<Municipio> municipios {get;set;}
        public AddMunicipioModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMunicipio)
        {
            _repoEstadio = repoEstadio;
            _repoMunicipio = repoMunicipio;
        }

        public void OnGet(int Estadioid)
        {
            estadio = _repoEstadio.GetEstadio(Estadioid);
            municipios = _repoMunicipio.GetAllMunicipios();
        }

        public IActionResult OnPost(int Estadioid, int Municipioid)
        {
            _repoEstadio.AsignarMunicipio(Estadioid, Municipioid);
            return RedirectToPage("Details", new{Estadioid = Estadioid});
        }
    }
}
