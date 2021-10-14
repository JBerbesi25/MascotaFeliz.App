using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisita
    {
         IEnumerable<Visita> GetAll();

        //IEnumerable<Mascota> GetMascotaPorFiltro(string filtro);

        Visita GetVisitaPorId(int visitaId);
        Visita Update(Visita visitaActualizada);
        Visita Add(Visita nuevaVisita);
    }
}