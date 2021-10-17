using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
    
    {
        IEnumerable<Veterinario> GetAllVeterinario();
        Veterinario AddVeterinario(Veterinario nuevoveterinario);
        Veterinario UpdateVeterinario(Veterinario veterinaroActualizado);
        void DeleteVeterinario(int veterinarioId);
        Veterinario GetVeterinario(int veterinarioId);    
    }
}