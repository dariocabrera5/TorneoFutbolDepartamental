using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.pages.Estadios
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        public Estadio estadio {get;set;}
        public DetailsModel(IRepositorioEstadio repoEstadio)
        {
            _repoEstadio = repoEstadio;
        }
        public IActionResult OnGet(int Estadioid)
        {
            estadio = _repoEstadio.GetEstadio(Estadioid);
            if(estadio == null)
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