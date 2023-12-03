using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Clave
    {

        public int ClaveId { get; set; }
        public string Contrasenia { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<AdministrativoClave> AdministrativoClave { get; set; }
    }
}
