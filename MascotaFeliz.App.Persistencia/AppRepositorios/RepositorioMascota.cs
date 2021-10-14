using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
private readonly AppContext _appContext;
        
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Mascota IRepositorioMascota.AddMascotas(Mascota nuevaMascota)
        {
            var mascotaadicionada = _appContext.Mascotas.Add(nuevaMascota);
            _appContext.SaveChanges();
            return mascotaadicionada.Entity;
        }

        Mascota IRepositorioMascota.UpdateMascotas(Mascota mascota)
        {
            var MascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.Id == mascota.Id);
            if (MascotaEncontrada != null)
                {
                    MascotaEncontrada.Id =mascota.Id;
                    MascotaEncontrada.Nombre=mascota.Nombre;
                    MascotaEncontrada.Propietario=mascota.Propietario;
                    MascotaEncontrada.Especie=mascota.Especie;
                    MascotaEncontrada.Raza=mascota.Raza;

                    _appContext.SaveChanges();
                }
                return MascotaEncontrada;
        }
        void IRepositorioMascota.DeleteMascotas(int mascotaId)
        {
            var MascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.Id == mascotaId);
            if (MascotaEncontrada == null)
                return;
            _appContext.Mascotas.Remove(MascotaEncontrada);
            _appContext.SaveChanges();
        }
        Mascota IRepositorioMascota.GetMascotas(int mascotaId)
        {
            return _appContext.Mascotas.FirstOrDefault(m => m.Id == mascotaId);
        } 

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return _appContext.Mascotas;
        }
    }
}