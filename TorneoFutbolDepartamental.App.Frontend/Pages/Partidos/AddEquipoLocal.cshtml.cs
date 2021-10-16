using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.Pages.Partidos
{
    public class AddEquipoLocalModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEquipo _repoEquipo;
        public Partido partido {get;set;}
        public IEnumerable<Equipo> equipos {get;set;}
        public AddEquipoLocalModel(IRepositorioPartido repoPartido, IRepositorioEquipo repoEquipo)
        {
            _repoPartido = repoPartido;
            _repoEquipo = repoEquipo;
        }
        public void OnGet(int Partidoid)
        {
            partido = _repoPartido.GetPartido(Partidoid);
            equipos = _repoEquipo.GetAllEquipos();
        }

        public IActionResult OnPost(int Partidoid, int Equipoid)
        {
            _repoPartido.AsignarEquipoLocal(Partidoid, Equipoid);
            return RedirectToPage("Details", new{Partidoid = Partidoid});
        }
    }
}
