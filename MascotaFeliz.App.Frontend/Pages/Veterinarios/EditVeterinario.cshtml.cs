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
    public class EditVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        [BindProperty]
        public Veterinario Veterinarios { get; set; }

        public EditVeterinarioModel ()
        {
            this.repositorioVeterinario =  new RepositorioVeterinario (new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? veterinarioId)
        {
            if(veterinarioId.HasValue)
            { 
            Veterinarios = repositorioVeterinario.GetVeterinario(veterinarioId.Value);
            }
            else 
            {
                Veterinarios=new Veterinario ();
            }
            if(Veterinarios==null)
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
            if(Veterinarios.Id>0)
            { 
            Veterinarios=repositorioVeterinario.UpdateVeterinario(Veterinarios);
            }
            else
            {
                repositorioVeterinario.AddVeterinario(Veterinarios);
            }
            return Page();
        }
    }
}
