using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Clave
    {
        [Key]
        [MaxLength(1)]
        public int ID_Clave { get; set; }
        public string Contrasenia { get; set; }
    }
}
