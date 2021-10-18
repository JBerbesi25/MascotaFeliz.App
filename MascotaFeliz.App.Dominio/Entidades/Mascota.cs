using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MascotaFeliz.App.Dominio
 {
     public class Mascota
     {
         public  int Id {get;set;}
         [Required(ErrorMessage = "No es un Nombre valido")]
         public string Nombre {get;set;}
         [Required(ErrorMessage = "No es una Especie valida")]
         public string Especie {get;set;}
         [Required(ErrorMessage = "No es una Raza valida")]
         public string Raza {get;set;}
     }
}