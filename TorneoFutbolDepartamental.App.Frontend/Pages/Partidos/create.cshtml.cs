using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbol.App.Frontend.pages.Partidos
{
    public class createModel : PageModel
    {
         private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get; set;}
        public createModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }

        public void OnGet()
        {
            partido = new Partido();
        }

        public IActionResult OnPost(Partido partido)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoPartido.AddPartido(partido);
            return RedirectToPage("Index");
        }
    }
}
