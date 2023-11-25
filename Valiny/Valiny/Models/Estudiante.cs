using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valiny.Models
{
    public class Estudiante
    {
        [Required]
        [Key]
        [MaxLength(15)]
        public int ID_Estudiante { get; set; }

        [ForeignKey("ID_Curso")]
        public  Curso IdCurso {  get; set; }

        [ForeignKey("ID_Registro")]
        public Registro IdRegistro { get; set; }

        [ForeignKey("ID_Documento")]
        public T_Documento IdDocumento { get; set; }

       [ForeignKey("ID_Genero")]
        public Genero IdGenero { get; set; } 

        [ForeignKey("ID_Admin")]
        public Administrativo IdAdmin { get; set; }
        [Required]
        [MaxLength(20)]
        public string P_Nombre {  get; set; }
        [MaxLength(20)]
        public string S_Nombre { get; set; } = string.Empty;
        [MaxLength(20)]
        public string T_Nombre { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]
        public string P_Apellido { get; set; }
        [MaxLength(20)]
        public string S_Apellido { get; set; }

    }
}
