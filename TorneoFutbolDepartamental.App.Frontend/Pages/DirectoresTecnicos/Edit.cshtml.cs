using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;


namespace TorneoFutbolDepartamental.App.Frontend.Pages.DirectoresTecnicos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico directorTecnico {get;set;}
        public EditModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public IActionResult OnGet(int DirectorTecnicoid)
        {
            directorTecnico = _repoDirectorTecnico.GetDirectorTecnico(DirectorTecnicoid);
            if(directorTecnico == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(DirectorTecnico directorTecnico)
        {
            if(ModelState.IsValid)
            {
                _repoDirectorTecnico.UpdateDirectorTecnico(directorTecnico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
