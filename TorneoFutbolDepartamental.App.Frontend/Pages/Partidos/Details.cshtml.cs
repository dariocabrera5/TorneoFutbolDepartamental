using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.pages.Partidos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get;set;}
        public DetailsModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }
        public IActionResult OnGet(int Partidoid)
        {
            partido = _repoPartido.GetPartido(Partidoid);
            if(partido == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
