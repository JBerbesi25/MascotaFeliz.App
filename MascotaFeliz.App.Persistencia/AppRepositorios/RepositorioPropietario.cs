using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{

    public class RepositorioPropietario : IRepositorioPropietario
    {
        private readonly AppContext _appContext;
        
        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Propietario IRepositorioPropietario.AddPropietario(Propietario nuevopropietario)
        {
            var propietarioadicionado = _appContext.Propietarios.Add(nuevopropietario);
            _appContext.SaveChanges();
            return propietarioadicionado.Entity;
        }

        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var propietarioadicionado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietario.Id);
            if (propietarioadicionado != null)
                {
                    propietarioadicionado.Id = propietario.Id;
                    propietarioadicionado.Identificacion = propietario.Identificacion;
                    propietarioadicionado.Nombres = propietario.Nombres;
                    propietarioadicionado.Apellidos = propietario.Apellidos;
                    propietarioadicionado.Telefono = propietario.Telefono;
                    propietarioadicionado.Direccion = propietario.Direccion;

                    _appContext.SaveChanges();
                }
                return propietarioadicionado;
        }
        void IRepositorioPropietario.DeletePropietario(int propietarioId)
        {
            var propietarioadicionado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietarioId);
            if (propietarioadicionado == null)
                return;
            _appContext.Propietarios.Remove(propietarioadicionado);
            _appContext.SaveChanges();
        }
        Propietario IRepositorioPropietario.GetPropietario(int propietarioId)
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.Id == propietarioId);
        } 

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietario()
        {
            return _appContext.Propietarios;
        }
    }
}
