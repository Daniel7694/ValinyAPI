using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Clave
    {
        [MaxLength(10)]
        public int ClaveId { get; set; }
        [MaxLength(10)]
        public string Contrasenia { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<AdministrativoClave> AdministrativoClave { get; set; }
    }
}
