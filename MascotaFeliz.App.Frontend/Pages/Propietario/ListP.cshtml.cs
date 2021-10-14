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
    public class ListPModelP : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;

        public IEnumerable<Propietario> Propietarios { get; set; }

        public ListPModelP()
        {
            this.repositorioPropietario = new RepositorioPropietario (new MascotaFeliz.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Propietarios=repositorioPropietario.GetAllPropietario();
        }
    }
}
