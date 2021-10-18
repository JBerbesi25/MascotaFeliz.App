using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{
    public class Visita
    {
        public int Id { get; set; }
        public int Veterinario { get; set; }
        public int Mascota { get; set; }
        public DateTime Fecha_hora { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Temperatura { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Peso { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int FreRespiratoria { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int FreCardiaca { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string EstadoAnimo { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Recomendaciones { get; set; }
    }
}