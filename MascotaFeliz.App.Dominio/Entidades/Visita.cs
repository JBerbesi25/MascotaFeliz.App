using System;
namespace MascotaFeliz.App.Dominio
{
    public class Visita
    {
        public int Id{get;set;}
        public DateTime Fecha_hora {get;set;}
         public float Temperatura{get;set;}
         public float Peso{get;set;}
         public int FreRespiratoria{get;set;}
         public int FreCardiaca{get;set;}
         public string EstadoAnimo{get;set;}
         public string Recomendaciones{get;set;}
    }
}