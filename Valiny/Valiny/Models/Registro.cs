using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class Registro
    {
        [Key]
        public int ID_Registro { get; set; }
        public string Nom_Registro { get; set; }
    }
}
