using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public int TiposRegistroId { get; set; }
        public int T_DocumentoId { get; set; }
        public int MatriculaId { get; set; }
        public int AdministrativoId { get; set; }
        public DateTime Fecha { get; set; }


        public virtual TiposRegistro TiposRegistro { get; set; }
        public virtual Matricula Matricula { get; set; }
        public virtual Administrativo Administrativo { get; set; }
    }
}
