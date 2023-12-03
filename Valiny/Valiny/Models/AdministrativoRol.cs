using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class AdministrativoRol
    {
        [MaxLength(10)]
        public int AdministrativoRolId { get; set; }
        [MaxLength(10)]
        public int AdministrativoId { get; set; }
        [MaxLength(10)]
        public int RolId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Estado { get; set; }

        public virtual Administrativo Administrativo { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
