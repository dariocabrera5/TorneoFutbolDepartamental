using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbol.App.Frontend.pages.Municipios
{
    public class createModel : PageModel
    {
         private readonly IRepositorioMunicipio _repoMunicipio;
        public Municipio municipio {get; set;}
        public createModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }

        public void OnGet()
        {
            municipio = new Municipio();
        }

        public IActionResult OnPost(Municipio municipio)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoMunicipio.AddMunicipio(municipio);
            return RedirectToPage("Index");
        }
    }
}
