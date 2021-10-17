using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{
    public class Propietario
    {
        public int Id {get;set;}
        [Required(ErrorMessage = "No es una identificación válida")]
        public int Identificacion{get;set;}
        [Required(ErrorMessage = "No nombre válido")]
         public string Nombres{get;set;}
         [Required(ErrorMessage = "No ")]
         public string Apellidos{get;set;}
         [Required(ErrorMessage = "No es una identificación válida")]
         public string Telefono{get;set;}
        public string Direccion {get;set;}
        public List<Mascota> Mascotas{get;set;}
    }
}