using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia.AppRepositorios;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class DetailsVModel : PageModel
    {
      private readonly IRepositorioVisita repositorioVisita;
      public readonly IRepositorioMascota _repoMascota;
        public readonly IRepositorioVeterinario _repoVeterinario;

        public Visita Visita{get;set;}

        public DetailsVModel()
        {
            this.repositorioVisita=new RepositorioVisita(new MascotaFeliz.App.Persistencia.AppContext());
            this._repoMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int visitaId)
        {
            Visita = repositorioVisita.GetVisita(visitaId);
            if(Visita==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
             return Page();  
        }
    }
}