using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valiny.Models
{
    public class Estudiante
    {
        [MaxLength(10)]
        public int EstudianteId { get; set; }
        [MaxLength(10)]
        public string P_Nombre { get; set; }
        [MaxLength(10)]
        public string S_Nombre { get; set; } = string.Empty;
        [MaxLength(10)]
        public string T_Nombre { get; set; } = string.Empty;
        [MaxLength(10)]
        public string P_Apellido { get; set; }
        [MaxLength(10)]
        public string S_Apellido { get; set; }
        [MaxLength(30)]
        public string T_Documento { get; set; }

        public virtual ICollection<Matricula> Matricula { get; set; }

    }
}
