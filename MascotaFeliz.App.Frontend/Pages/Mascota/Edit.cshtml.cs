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
    public class EditModelM : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        [BindProperty]
        public Mascota Mascota { get; set; }

        public EditModelM()
        {
            this.repositorioMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? mascotaId)
        {
            if(mascotaId.HasValue)
            { 
            Mascota = repositorioMascota.GetMascotas(mascotaId.Value);
            }
            else 
            {
                Mascota=new Mascota ();
            }
            if(Mascota==null)
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
            if(Mascota.Id>0)
            { 
            Mascota=repositorioMascota.UpdateMascotas(Mascota);
            }
            else
            {
                repositorioMascota.AddMascotas(Mascota);
            }
            return Page();
        }

    }
}

