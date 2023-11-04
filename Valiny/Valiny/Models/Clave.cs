using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Clave
    {
        [Key]
        public int ID_Clave { get; set; }
        public string Contraseña { get; set; }
    }
}
