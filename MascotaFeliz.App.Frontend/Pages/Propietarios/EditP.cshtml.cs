using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;
        [BindProperty]
        public Propietario Propietarios { get; set; }

        public EditPropietariosModel ()
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
                var propietario=repositorioPropietario.UpdatePropietario(Propietarios);
                ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Success, "<span><strong>"+propietario.Nombres+" "+propietario.Apellidos+"</strong> fue modificado correctamente.</span>");
            }
            else
            {
                var propietario = repositorioPropietario.AddPropietario(Propietarios);
                ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Primary, "<span><strong>"+propietario.Nombres+" "+propietario.Apellidos+"</strong> se agregó a la lista de propietarios.</span>");
            }
            return Page();
        }

    }
}

