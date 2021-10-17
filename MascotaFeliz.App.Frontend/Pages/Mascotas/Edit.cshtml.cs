using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Text.Json;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditMascotasModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioPropietario repositorioPropietario;
        [BindProperty]
        public Mascota Mascota { get; set; }
        public Propietario propietario { get; set; }

        public EditMascotasModel()
        {
            this.repositorioMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
            this.repositorioPropietario = new RepositorioPropietario(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? mascotaId, int? propietarioId)
        {
            if(mascotaId.HasValue && propietarioId.HasValue)
            { 
                propietario = repositorioPropietario.GetPropietario(propietarioId.Value);
                Mascota = repositorioMascota.GetMascotas(mascotaId.Value);
            }
            else 
            {
                  if (propietarioId.HasValue)
                {
                    propietario = repositorioPropietario.GetPropietario(propietarioId.Value);
                }else{
                    return RedirectToPage("/Propietario/ListP");
                }
                Mascota=new Mascota ();
            }
            if(Mascota==null || propietario ==null)
            {
                return RedirectToPage("/Propietario/ListP");
            }
            else
                ViewData["propietario"] = propietarioId.Value;
                return Page();
        }
        public IActionResult OnPost()
        {
             propietario = repositorioPropietario.GetPropietario(int.Parse(Request.Form["propietarioId"]));
              if (!ModelState.IsValid)
            {
                 Console.WriteLine("no valido");
                return Page();
            }
            if(Mascota.Id>0)
            { 
                var mascotae=repositorioMascota.UpdateMascotas(Mascota);
            ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Success, "<span><strong>" + mascotae.Nombre + "</strong> fue modificado correctamente.</span>");
            }
            else
            {
                {
                    if (propietario.Mascotas != null)
                    {
                        propietario.Mascotas.Add(Mascota);
                        repositorioPropietario.UpdatePropietario(propietario);
                        ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Primary, "<span><strong>" + Mascota.Nombre + "</strong> se agregó una nueva mascota para " + propietario.Nombres + " " + propietario.Apellidos + ".</span>");
                    }
                    else
                    {
                        propietario.Mascotas = new List<Mascota>(){Mascota};
                        Console.WriteLine(JsonSerializer.Serialize(propietario));
                        repositorioPropietario.UpdatePropietario(propietario);
                        ViewData["Respuesta"] = Alerts.ShowAlert(Alert.Primary, "<span><strong>" + Mascota.Nombre + "</strong> se agregó a la lista de mascotas de " + propietario.Nombres + " " + propietario.Apellidos + ".</span>");
                    }
                }
            }
            ViewData["propietario"] = propietario.Id;
            return Page();
        }

    }
}

