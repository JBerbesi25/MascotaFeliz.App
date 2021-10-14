using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Frontend
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;

        public IEnumerable<Mascota> Mascotas { get; set; }

        public ListModel()
        {
            this.repositorioMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            Mascotas = repositorioMascota.GetAllMascotas();
        }
    }
}
