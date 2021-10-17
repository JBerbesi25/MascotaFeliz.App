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
    public class DeleteVModel : PageModel
    {
       private readonly IRepositorioVisita repositorioVisita;
        [BindProperty]
        public Visita Visita { get; set; }

        public DeleteVModel()
        {
            this.repositorioVisita = new RepositorioVisita(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? visitaId)
        {
            if(visitaId.HasValue)
            { 
              Visita = repositorioVisita.GetVisita(visitaId.Value);
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
                if (!ModelState.IsValid)
            {
                return Page();
            }
            if(Visita.Id>0)
            { 
              repositorioVisita.DeleteVisita(Visita.Id);
            }
            else
            {
                repositorioVisita.AddVisita(Visita);
            }
            return Page();
        }
    }
}
