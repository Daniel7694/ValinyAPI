using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Curso
    {
        [MaxLength(2)]
        public int CursoId { get; set; }
        [MaxLength(4)]
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Matricula> Matricula { get; set; }
    }
}
