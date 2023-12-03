using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Rol
    {
        [MaxLength(10)]
        public int RolId { get; set; }
        [MaxLength(20)]
        public string NombreRol { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<AdministrativoRol> AdministrativoRol { get; set; }
    }
}
