using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAll();

        //IEnumerable<Mascota> GetMascotaPorFiltro(string filtro);

        Mascota GetMascotaPorId(int mascotaId);
    }
 }