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
    public class DeletePModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;
        [BindProperty]
        public Propietario Propietarios { get; set; }

        public DeletePModel ()
        {
            this.repositorioPropietario =  new RepositorioPropietario (new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? propietarioId)
        {
            if(propietarioId.HasValue)
            { 
            Propietarios = repositorioPropietario.GetPropietario(propietarioId.Value);
            }
            else 
            {
                Propietarios=new Propietario ();
            }
            if(Propietarios==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
              if (!ModelState.IsValid)
            {
                return Page();
            }
            if(Propietarios.Id>0)
            { 
             repositorioPropietario.DeletePropietario(Propietarios.Id);
            }
            else
            {
                repositorioPropietario.AddPropietario(Propietarios);
            }
            return Page();
        }   
    }
}
