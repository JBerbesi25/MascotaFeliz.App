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
    public class DetailsModel : PageModel
    {
         private readonly IRepositorioMascota repositorioMascota;

        public Mascota Mascotas{ get; set;}

        public DetailsModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota=repositorioMascota;
        }
        public IActionResult OnGet(int mascotaId)
        {
            Mascotas = repositorioMascota.GetMascotaPorId(mascotaId);
            if(Mascotas==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
             return Page(); 

            
        }
    }
}
