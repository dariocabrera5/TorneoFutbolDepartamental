using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.Pages.Equipos
{
    public class AddDirectorTecnicoModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public Equipo equipo {get;set;}
        public IEnumerable<DirectorTecnico> directoresTecnicos {get;set;}
        public AddDirectorTecnicoModel(IRepositorioEquipo repoEquipo, IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoEquipo = repoEquipo;
            _repoDirectorTecnico = repoDirectorTecnico; 
        }
        public void OnGet(int Equipoid)
        {
            equipo = _repoEquipo.GetEquipo(Equipoid);
            directoresTecnicos = _repoDirectorTecnico.GetAllDirectoresTecnicos();
        }

        public IActionResult OnPost(int Equipoid, int DirectorTecnicoid)
        {
            _repoEquipo.AsignarDirectorTecnico(Equipoid, DirectorTecnicoid);
            return RedirectToPage("Details", new{Equipoid = Equipoid});
        }
    }
}
