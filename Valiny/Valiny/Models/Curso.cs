using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Matricula> Matricula { get; set; }
    }
}
