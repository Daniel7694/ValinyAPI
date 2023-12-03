namespace Valiny.Models
{
    public class AdministrativoClave
    {
        public int AdministrativoClaveId { get; set; }
        public int AdministrativoId { get; set; }
        public int ClaveId { get; set; }
        public bool Estado { get; set; }

        public virtual Administrativo Administrativo { get; set; }
        public virtual Clave Clave { get; set; }
    }
}
