using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    
    {
        IEnumerable<Propietario> GetAllPropietario();
        Propietario AddPropietario(Propietario nuevopropietario);
        Propietario UpdatePropietario(Propietario propietarioActualizado);
        void DeletePropietario(int propietarioId);
        Propietario GetPropietario(int propietarioId);
        
        
    }
   }
