using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.pages.Partidos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public IEnumerable<Partido> partidos {get;set;}
        public IndexModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }
        public void OnGet()
        {
            partidos = _repoPartido.GetAllPartidos();
        }
    }
}
