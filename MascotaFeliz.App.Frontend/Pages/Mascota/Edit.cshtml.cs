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
    public class EditModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        [BindProperty]
        public Mascota Mascota { get; set; }

        public EditModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
        public IActionResult OnGet(int? mascotaId)
        {
            if(mascotaId.HasValue)
            { 
            Mascota = repositorioMascota.GetMascotaPorId(mascotaId.Value);
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
            if(Mascota.Id>0)
            { 
            Mascota=repositorioMascota.Update(Mascota);
            }
            else
            {
                repositorioMascota.Add(Mascota);
            }
            return Page();
        }

    }
}

