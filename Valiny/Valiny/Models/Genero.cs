using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Genero
    {
        [Key]
        [MaxLength(1)]
        public int ID_Genero { get; set; }
        public string Nom_Genero { get; set; }
    }
}
