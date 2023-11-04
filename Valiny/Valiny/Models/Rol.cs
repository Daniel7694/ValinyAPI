using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Rol
    {
        [Key]
        public int ID_Rol {  get; set; }
        public string Nombre_Rol { get; set; }
    }
}
