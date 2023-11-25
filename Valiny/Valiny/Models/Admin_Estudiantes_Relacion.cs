using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valiny.Models
{
    public class Admin_Estudiantes_Relacion
    {
        [Key]
        [Required]
        public int ID_Relacion {  get; set; }
        [ForeignKey("ID_Admin")]
        public Administrativo IdAdmin { get; set; }
        [ForeignKey("ID_Estudiante")]
        public Estudiante IdEstudiante { get; set; }


    }
}
