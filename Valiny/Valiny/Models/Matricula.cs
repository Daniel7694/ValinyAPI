using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valiny.Models
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public DateTime? Fecha { get; set; }
        public int EstudianteId { get; set; }
        public int CursoId { get; set; }

        public virtual Estudiante Estudiante { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual ICollection<Registro> Registro { get; set; }


    }
}
