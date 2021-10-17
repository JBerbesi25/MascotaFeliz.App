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
        public readonly IRepositorioMascota _repoMascota;
        public readonly IRepositorioVeterinario _repoVeterinario;

        public IEnumerable<Visita> Visitas {get;set;}

        public ListVModel()
        {
            this.repositorioVisita = new RepositorioVisita(new MascotaFeliz.App.Persistencia.AppContext());
            this._repoMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Visitas=repositorioVisita.GetAllVisita();
        }
    }
}
