using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;


namespace TorneoFutbolDepartamental.App.Frontend.Pages.Municipios
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Municipio municipio {get;set;}
        public EditModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }
        public IActionResult OnGet(int Municipioid)
        {
            municipio = _repoMunicipio.GetMunicipio(Municipioid);
            if(municipio == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Municipio municipio)
        {
            if(ModelState.IsValid)
            {
                _repoMunicipio.UpdateMunicipio(municipio);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
