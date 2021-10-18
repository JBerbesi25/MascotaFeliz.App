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
        [Required(ErrorMessage = "No es un nombre válido")]
         public string Nombres{get;set;}
         [Required(ErrorMessage = "No es un Apellido Valido ")]
         public string Apellidos{get;set;}
         [Required(ErrorMessage = "No es un Telefono valido")]
         public string Telefono{get;set;}
         [Required(ErrorMessage = "No es una Direccion valida")]
        public string Direccion {get;set;}
        public List<Mascota> Mascotas{get;set;}
    }
}