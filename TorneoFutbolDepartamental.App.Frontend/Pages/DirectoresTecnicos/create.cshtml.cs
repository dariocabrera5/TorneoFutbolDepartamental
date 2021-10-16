using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbol.App.Frontend.pages.DirectoresTecnicos
{  
    public class createModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico directortecnico {get; set;}
        public createModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }

        public void OnGet()
        {
            directortecnico = new DirectorTecnico();
        }

        public IActionResult OnPost(DirectorTecnico directortecnico)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoDirectorTecnico.AddDirectorTecnico(directortecnico);
            return RedirectToPage("Index");
        }
    }
}
