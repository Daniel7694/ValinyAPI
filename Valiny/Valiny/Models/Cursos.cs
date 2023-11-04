using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Cursos
    {
        [Key]
        public int ID_Curso {  get; set; }
        public int Num_Curso { get; set; }
    }
}
