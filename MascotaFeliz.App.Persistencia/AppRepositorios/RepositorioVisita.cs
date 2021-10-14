using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioVisita : IRepositorioVisita
    {
        private readonly List<Visita> visitas;

        public RepositorioVisita()
        {
            visitas = new List<Visita>()
                    {
                    new Visita {Id=1, Fecha_hora = new DateTime (2016, 08, 25, 9, 30, 45), Temperatura="38.1", Peso="12 Kg", FreRespiratoria=14, FreCardiaca=92,  EstadoAnimo="contento", Recomendaciones="Ninguna"},
                    new Visita {Id=2, Fecha_hora = new DateTime (2021, 11, 09,10, 31, 50), Temperatura="39.2", Peso="18 Kg", FreRespiratoria=12, FreCardiaca=83,  EstadoAnimo="contento", Recomendaciones="Ninguna"},
                    new Visita {Id=3, Fecha_hora = new DateTime (2021, 11, 12, 17, 25, 15), Temperatura="37.7", Peso="10 Kg", FreRespiratoria=16, FreCardiaca=102, EstadoAnimo="contento", Recomendaciones="Ninguna"}
                    };

        }

        public Visita Add(Visita nuevaVisita)
        {
            nuevaVisita.Id = visitas.Max(r => r.Id) + 1;
            visitas.Add(nuevaVisita);
            return nuevaVisita;
        }

        public IEnumerable<Visita> GetAll()
        {

            return visitas;

        }
        public Visita GetVisitaPorId(int VisitaId)
        {
            return visitas.SingleOrDefault(vi => vi.Id == VisitaId);
        }
        public Visita Update(Visita visitaActualizada)
        {
            var visita = visitas.SingleOrDefault(r => r.Id == visitaActualizada.Id);
            if (visita != null)
            {
                visita.Fecha_hora = visitaActualizada.Fecha_hora;
                visita.Temperatura = visitaActualizada.Temperatura;
                visita.Peso = visitaActualizada.Peso;
                visita.FreRespiratoria = visitaActualizada.FreRespiratoria;
                visita.FreCardiaca = visitaActualizada.FreCardiaca;
                visita.EstadoAnimo = visitaActualizada.EstadoAnimo;
                visita.Recomendaciones = visitaActualizada.Recomendaciones;
            }
            return visita;
        }
    }
}