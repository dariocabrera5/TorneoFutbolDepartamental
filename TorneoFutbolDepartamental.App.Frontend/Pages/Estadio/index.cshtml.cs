using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Persistencia;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Frontend.Pages.Estadio
{
    public class indexModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        public IEnumerable<Estadio> Estadiose {get;set;}
        public indexModel(IRepositorioEstadio repoEstadio){
            _repoEstadio = repoEstadio;

        }
        public void OnGet()
        {
            Estadiose = _repoEstadio.GetAllEstadios();
        }
    }
}
