using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.pages.Jugadores
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public Jugador jugador {get;set;}
        public DetailsModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }
        public IActionResult OnGet(int Jugadorid)
        {
            jugador = _repoJugador.GetJugador(Jugadorid);
            if(jugador == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
