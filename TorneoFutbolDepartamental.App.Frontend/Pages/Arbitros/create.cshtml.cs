using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbol.App.Frontend.pages.Arbitros
{
  public class createModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public Arbitro arbitro {get; set;}
        public createModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }

        public void OnGet()
        {
            arbitro = new Arbitro();
        }

        public IActionResult OnPost(Arbitro arbitro)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoArbitro.AddArbitro(arbitro);
            return RedirectToPage("Index");
        }
    }
}
