using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly List<Mascota> mascotas;

        public RepositorioMascota()
        {
            mascotas = new List<Mascota>()
                    {
                    new Mascota {Id=1, Nombre="Kirara", Propietario="jorge", Especie="canino", Raza="criollo"},
                    new Mascota {Id=2, Nombre="Itachi", Propietario="angela", Especie="canino", Raza="pitbull"},
                    new Mascota {Id=3, Nombre="Corage", Propietario="isabel", Especie="felino", Raza="criollo"},
                    };
                    
                 }
        public IEnumerable<Mascota> GetAll()
        {

         return mascotas;

        }
     public Mascota GetMascotaPorId(int MascotaId)
        {
            return mascotas.SingleOrDefault(m => m.Id==MascotaId);
        }
     }

    }