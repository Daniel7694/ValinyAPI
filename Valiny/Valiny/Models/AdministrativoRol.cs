namespace Valiny.Models
{
    public class AdministrativoRol
    {
        public int AdministrativoRolId { get; set; }
        public int AdministrativoId { get; set; }
        public int RolId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Estado { get; set; }

        public virtual Administrativo Administrativo { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
