using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioVisita : IRepositorioVisita
    {
        private readonly AppContext _appContext;
        
        public RepositorioVisita(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Visita IRepositorioVisita.AddVisita(Visita nuevavisita)
        {
            var visitaadicionada = _appContext.Visitas.Add(nuevavisita);
            _appContext.SaveChanges();
            return visitaadicionada.Entity;
        }

        Visita IRepositorioVisita.UpdateVisita(Visita visita)
        {
            var VisitaEncontrada = _appContext.Visitas.FirstOrDefault(v => v.Id == visita.Id);
            if (VisitaEncontrada != null)
                {
                    VisitaEncontrada.Id =visita.Id;
                    VisitaEncontrada.Fecha_hora=visita.Fecha_hora;
                    VisitaEncontrada.Temperatura=visita.Temperatura;
                    VisitaEncontrada.Peso=visita.Peso;
                    VisitaEncontrada.FreRespiratoria=visita.FreRespiratoria;
                    VisitaEncontrada.FreCardiaca=visita.FreCardiaca;
                    VisitaEncontrada.EstadoAnimo=visita.EstadoAnimo;
                    VisitaEncontrada.Recomendaciones=visita.Recomendaciones;

                    _appContext.SaveChanges();
                }
                return VisitaEncontrada;
        }
        void IRepositorioVisita.DeleteVisita(int visitaId)
        {
            var VisitaEncontrada = _appContext.Visitas.FirstOrDefault(v => v.Id == visitaId);
            if (VisitaEncontrada == null)
                return;
            _appContext.Visitas.Remove(VisitaEncontrada);
            _appContext.SaveChanges();
        }
        Visita IRepositorioVisita.GetVisita(int visitaId)
        {
            return _appContext.Visitas.FirstOrDefault(v => v.Id == visitaId);
        } 

        IEnumerable<Visita> IRepositorioVisita.GetAllVisita()
        {
            return _appContext.Visitas;
        }
    }
}