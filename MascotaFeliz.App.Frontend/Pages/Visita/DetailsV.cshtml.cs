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

        public Visita Visita{get;set;}

        public DetailsVModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita=repositorioVisita;
        }
        public IActionResult OnGet(int VisitaId)
        {
            Visita = repositorioVisita.GetVisitaPorId(VisitaId);
            if(Visita==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
             return Page();  
        }
    }
}
