using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{
    public class Veterinario
    {
        public int Id {get;set;}
         [Required(ErrorMessage = "Campo Obligatorio")]
        public int Identificacion{get;set;}
        [Required(ErrorMessage = "Campo Obligatorio")]
         public string Nombres{get;set;}
         [Required(ErrorMessage = "Campo Obligatorio")]
         public string Apellidos{get;set;}
         [Required(ErrorMessage = "Campo Obligatorio")]
         public string Telefono{get;set;}
         [Required(ErrorMessage = "Campo Obligatorio")]
        public string Direccion {get;set;}
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string TarjetaProfesional {get;set;}
    }
}