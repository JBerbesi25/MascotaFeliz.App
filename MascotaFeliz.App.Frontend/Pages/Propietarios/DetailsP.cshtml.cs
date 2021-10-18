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
    public class DetailsPropietariosModel : PageModel
    {
         private readonly IRepositorioPropietario repositorioPropietario;
         private readonly IRepositorioMascota repositorioMascota;


        public Propietario Propietario{ get; set;}

        public DetailsPropietariosModel ()
        {
            this.repositorioPropietario=  new RepositorioPropietario (new MascotaFeliz.App.Persistencia.AppContext());
            this.repositorioMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int propietarioId)
        {
            Propietario = repositorioPropietario.GetPropietario(propietarioId);
            if(Propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
             return Page();             
        }
        public void OnPost(int idmascota,int idpropietario)
        {
            try
            {
                  repositorioMascota.DeleteMascotas(idmascota);
                  ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Danger, "<span>La mascota seleccionada se eliminó.</span>");
            }
            catch (System.Exception)
            {
                  ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Warning, "<span>No se puede eliminar la mascota porque tiene visitas asociadas.</span>");
                
            }
           
            Propietario = repositorioPropietario.GetPropietario(idpropietario);            
        }
    }
}
