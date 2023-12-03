using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Rol
    {
        public int RolId { get; set; }
        public string NombreRol { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<AdministrativoRol> AdministrativoRol { get; set; }
    }
}
