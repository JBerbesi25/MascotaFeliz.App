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
    public class DetailsVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;

        public Veterinario Veterinarios{ get; set;}

        public DetailsVeterinarioModel()
        {
            this.repositorioVeterinario=new RepositorioVeterinario(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int veterinarioId)
        {
            Veterinarios = repositorioVeterinario.GetVeterinario(veterinarioId);
            if(Veterinarios==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
             return Page();    
        }
    }
}
