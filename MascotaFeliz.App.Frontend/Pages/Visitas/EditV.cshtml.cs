using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;
using System.Text.Json;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditVModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisita;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioMascota _repoMascota;
        [BindProperty]
        public Visita Visita { get; set; }
        public IEnumerable<Veterinario> Veterinarios;
        public IEnumerable<Mascota> Mascotas;

        public EditVModel()
        {
            this.repositorioVisita = new RepositorioVisita(new MascotaFeliz.App.Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            Veterinarios = _repoVeterinario.GetAllVeterinario();
            Mascotas = _repoMascota.GetAllMascotas();
        }
        public IActionResult OnGet(int? visitaId)
        {
            if (visitaId.HasValue)
            {
                Visita = repositorioVisita.GetVisita(visitaId.Value);
            }
            else
            {
                Visita = new Visita();
            }
            if (Visita == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
        public IActionResult OnPost(int mascota, int veterinario)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            Visita.Mascota = mascota;
            Visita.Veterinario = veterinario;
            Console.WriteLine(JsonSerializer.Serialize(Visita));
            if (Visita.Id > 0)
            {
                Visita = repositorioVisita.UpdateVisita(Visita);
            }
            else
            {
                repositorioVisita.AddVisita(Visita);
            }
            return Page();
        }
    }
}
