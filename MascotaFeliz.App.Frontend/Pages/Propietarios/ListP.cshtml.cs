using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend
{
    public class ListPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;

        public IEnumerable<Propietario> Propietarios { get; set; }

        public ListPropietariosModel()
        {
            this.repositorioPropietario = new RepositorioPropietario (new MascotaFeliz.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Propietarios=repositorioPropietario.GetAllPropietario();
        }
         public void OnPost(int idpropietario)
        {
            try
            {
                 repositorioPropietario.DeletePropietario(idpropietario);
                 ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Danger, "<span>Se eliminó el propietario seleccionado.</span>");
            }
            catch (System.Exception)
            {
                ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Warning, "<span>No se puede eliminar el propietario porque tiene mascotas asignadas.</span>");
            }
            Propietarios=repositorioPropietario.GetAllPropietario();            
        }
    }
}
