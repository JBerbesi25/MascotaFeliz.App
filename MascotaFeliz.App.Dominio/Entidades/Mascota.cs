using System;
namespace MascotaFeliz.App.Dominio
 {
     public class Mascota
     {
         public  int Id{get;set;}
         public string Nombre{get;set;}
         public Propietario Propietario {get;set;}
         public string Especie{get;set;}
         public string Raza{get;set;}
     }
}