using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{

    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext;
        
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario nuevoveterinario)
        {
            var veterinarioadicionado = _appContext.Veterinarios.Add(nuevoveterinario);
            _appContext.SaveChanges();
            return veterinarioadicionado.Entity;
        }

        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioadicionado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinario.Id);
            if (veterinarioadicionado != null)
                {
                    veterinarioadicionado.Id = veterinario.Id;
                    veterinarioadicionado.Identificacion = veterinario.Identificacion;
                    veterinarioadicionado.Nombres = veterinario.Nombres;
                    veterinarioadicionado.Apellidos = veterinario.Apellidos;
                    veterinarioadicionado.Telefono = veterinario.Telefono;
                    veterinarioadicionado.Direccion = veterinario.Direccion;
                    veterinarioadicionado.TarjetaProfesional = veterinario.TarjetaProfesional;

                    _appContext.SaveChanges();
                }
                return veterinarioadicionado;
        }
        void IRepositorioVeterinario.DeleteVeterinario(int veterinarioId)
        {
            var veterinarioadicionado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioId);
            if (veterinarioadicionado == null)
                return;
            _appContext.Veterinarios.Remove(veterinarioadicionado);
            _appContext.SaveChanges();
        }
        Veterinario IRepositorioVeterinario.GetVeterinario(int veterinarioId)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioId);
        } 

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinario()
        {
            return _appContext.Veterinarios;
        }
    }
}