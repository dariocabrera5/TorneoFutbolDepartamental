using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.pages.Equipos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        public Equipo equipo {get;set;}
        public DetailsModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo = repoEquipo;
        }
        public IActionResult OnGet(int Equipoid)
        {
            equipo = _repoEquipo.GetEquipo(Equipoid);
            if(equipo == null)
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
