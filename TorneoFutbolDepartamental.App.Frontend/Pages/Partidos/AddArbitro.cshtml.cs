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
    public class AddArbitroModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioArbitro _repoArbitro;
        public Partido partido {get;set;}
        public IEnumerable<Arbitro> arbitros {get;set;}
        public AddArbitroModel(IRepositorioPartido repoPartido, IRepositorioArbitro repoArbitro)
        {
            _repoPartido = repoPartido;
            _repoArbitro = repoArbitro;
        }
        public void OnGet(int Partidoid)
        {
            partido = _repoPartido.GetPartido(Partidoid);
            arbitros = _repoArbitro.GetAllArbitros();
        }

        public IActionResult OnPost(int Partidoid, int Arbitroid)
        {
            _repoPartido.AsignarArbitro(Partidoid, Arbitroid);
            return RedirectToPage("Details", new{Partidoid = Partidoid});
        }
    }
}
