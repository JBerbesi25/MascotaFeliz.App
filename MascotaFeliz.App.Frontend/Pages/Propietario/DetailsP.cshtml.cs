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
    public class DetailsPModelP : PageModel
    {
         private readonly IRepositorioPropietario repositorioPropietario;

        public Propietario Propietarios{ get; set;}

        public DetailsPModelP ()
        {
            this.repositorioPropietario=  new RepositorioPropietario (new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int propietarioId)
        {
            Propietarios = repositorioPropietario.GetPropietario(propietarioId);
            if(Propietarios==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
             return Page(); 

            
        }
    }
}
