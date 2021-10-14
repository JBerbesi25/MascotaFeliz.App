using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditVModel : PageModel
    {
         private readonly IRepositorioVisita repositorioVisita;
        [BindProperty]
        public Visita Visita { get; set; }

        public EditVModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita = repositorioVisita;
        }
        public IActionResult OnGet(int? visitaId)
        {
            if(visitaId.HasValue)
            { 
              Visita = repositorioVisita.GetVisitaPorId(visitaId.Value);
            }
            else 
            {
                Visita=new Visita ();
            }
            if(Visita==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if(Visita.Id>0)
            { 
              Visita=repositorioVisita.Update(Visita);
            }
            else
            {
                repositorioVisita.Add(Visita);
            }
            return Page();
        }
    }
}
