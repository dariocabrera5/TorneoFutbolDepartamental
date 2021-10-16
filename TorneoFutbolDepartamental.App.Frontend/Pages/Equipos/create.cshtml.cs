using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbol.App.Frontend.pages.Eqipos
{public class createModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        public Equipo equipo {get; set;}
        public IEnumerable<DirectorTecnico> directorestecnicos {get; set;}
        public IEnumerable<Municipio> municipios {get; set;}
        public createModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo = repoEquipo;
        }

        public void OnGet()
        {
            equipo = new Equipo();
        }

        public IActionResult OnPost(Equipo equipo)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoEquipo.AddEquipo(equipo);
            return RedirectToPage("Index");
        }
    }
}
