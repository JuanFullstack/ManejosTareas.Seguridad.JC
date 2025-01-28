using System.ComponentModel.DataAnnotations;

namespace ManejosTareas.Seguridad.JC.Models
{
    public class PasoCrearDTO
    {
        [Required]
        public string Descripcion { get; set; }
        public bool Realizado { get; set; }
    }
}
