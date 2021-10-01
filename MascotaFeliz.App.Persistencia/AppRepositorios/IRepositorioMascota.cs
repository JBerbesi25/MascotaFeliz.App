using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascota();
        Mascota AddPaciente(Mascota mascotas);
        Mascota UpdateMascota(Mascota mascotas);//original del Ing. Oscar
        Mascota UpdateMascota(Mascota mascotas, int idMascota_original);//modificada por mi para que funcionara
        void DeleteMascota(int idMascota);    
        Mascota GetMascota(int idMascota);
        //Medico AsignarMedico(int idPaciente, int idMedico); 


    }


}