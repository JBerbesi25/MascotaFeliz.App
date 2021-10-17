using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisita
    {
        IEnumerable<Visita> GetAllVisita();
        Visita AddVisita(Visita nuevavisita);
        Visita UpdateVisita(Visita visitaActualizada);
        void DeleteVisita(int visitaId);
        Visita GetVisita(int visitaId);
    }
}