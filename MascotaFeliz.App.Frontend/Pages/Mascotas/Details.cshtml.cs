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
    public class DetailsMascotasModel : PageModel
    {
         private readonly IRepositorioMascota repositorioMascota;

        public Mascota Mascotas{ get; set;}

        public DetailsMascotasModel()
        {
            this.repositorioMascota=new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int mascotaId,int propietarioId)
        {
            Mascotas = repositorioMascota.GetMascotas(mascotaId);
            if(Mascotas==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            ViewData["propietario"]=propietarioId;
             return Page(); 

            
        }
    }
}
