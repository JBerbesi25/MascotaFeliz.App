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
    public class ListModel : PageModel
    {
         private readonly IRepositorioMascota repositorioMascota;
        public IEnumerable<Mascota> Mascotas{get;set;}

        public ListModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota=repositorioMascota;
        }
        public void OnGet()
        {
            Mascotas=repositorioMascota.GetAll();
        }
    }
}
