using System;
namespace MascotaFeliz.App.Dominio
{
    public class Visita
    {
        public int Id{get;set;}
        public Propietario IdPropietario {get;set;}
        public Mascota IdMascota{get;set;}
        public DateTime Fecha_hora {get;set;}
         public string Temperatura{get;set;}
         public string Peso{get;set;}
         public int FreRespiratoria{get;set;}
         public int FreCardiaca{get;set;}
         public string EstadoAnimo{get;set;}
         public string Recomendaciones{get;set;}
    }
}