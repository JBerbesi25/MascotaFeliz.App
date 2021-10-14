using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
      IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascotas(Mascota nuevaMascota);
        Mascota UpdateMascotas(Mascota mascotaActualizada);
        void DeleteMascotas(int mascotaId);
        Mascota GetMascotas(int mascotaId);
    }
 }