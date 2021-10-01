using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
        List<Mascota> mascotas;

        public RepositorioMascota()
        {
            mascotas = new List<Mascota>()
            {
                new Mascota{Id=1,Nombre="Violeta",Propietario="Carlos Martinez", Especie="Canino", Raza="Criolla"},
                new Mascota{Id=2,Nombre="Luna",Propietario="Juan Lopez", Especie="Felino", Raza="Persa"},
                new Mascota{Id=3,Nombre="Capitan",Propietario="Sandra Arango", Especie="Canino", Raza="Labrador"},
            };
        }
        public IEnumerable<Mascota> GetAll()
        {
            return mascotas;
        }
    }
}