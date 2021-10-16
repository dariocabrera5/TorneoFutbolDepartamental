using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.Pages.Partidos
{
    public class AddEstadioModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEstadio _repoEstadio;
        public Partido partido {get;set;}
        public IEnumerable<Estadio> estadios {get;set;}
        public AddEstadioModel(IRepositorioPartido repoPartido, IRepositorioEstadio repoEstadio)
        {
            _repoPartido = repoPartido;
            _repoEstadio = repoEstadio;
        }
        public void OnGet(int Partidoid)
        {
            partido = _repoPartido.GetPartido(Partidoid);
            estadios = _repoEstadio.GetAllEstadios();
        }

        public IActionResult OnPost(int Partidoid, int Estadioid)
        {
            _repoPartido.AsignarEstadio(Partidoid, Estadioid);
            return RedirectToPage("Details", new{Partidoid = Partidoid});
        }
    }
}
