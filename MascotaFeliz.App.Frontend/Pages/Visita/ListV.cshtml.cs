using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia.AppRepositorios;

namespace MascotaFeliz.App.Frontend
{
    public class ListVModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisita;

        public IEnumerable<Visita> Visitas {get;set;}

        public ListVModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita = repositorioVisita;
        }
        public void OnGet()
        {
            Visitas=repositorioVisita.GetAll();
        }
    }
}
