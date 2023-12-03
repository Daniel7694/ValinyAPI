using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valiny.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string P_Nombre { get; set; }
        public string S_Nombre { get; set; }
        public string P_Apellido { get; set; }
        public string S_Apellido { get; set; }
        public string T_Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual ICollection<Matricula> Matricula { get; set; }

    }
}
