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

        public Mascota Mascota { get; set; }

        public EditModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
        public IActionResult OnGet(int mascotaId)
        {
            Mascota = repositorioMascota.GetMascotaPorId(mascotaId);
            if(Mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}

