using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class AdministrativoClave
    {
        [MaxLength (10)]
        public int AdministrativoClaveId { get; set; }
        [MaxLength(10)]
        public int AdministrativoId { get; set; }
        [MaxLength(10)]
        public int ClaveId { get; set; }
        public bool Estado { get; set; }

        public virtual Administrativo Administrativo { get; set; }
        public virtual Clave Clave { get; set; }
    }
}
