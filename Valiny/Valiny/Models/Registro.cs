using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Registro
    {
        [MaxLength(10)]
        public int RegistroId { get; set; }
        [MaxLength(10)]
        public int TiposRegistroId { get; set; }
        [MaxLength(10)]
        public int MatriculaId { get; set; }
        [MaxLength(10)]
        public int AdministrativoId { get; set; }
        public DateTime Fecha { get; set; }


        public virtual TiposRegistro TiposRegistro { get; set; }
        public virtual Matricula Matricula { get; set; }
        public virtual Administrativo Administrativo { get; set; }
    }
}
