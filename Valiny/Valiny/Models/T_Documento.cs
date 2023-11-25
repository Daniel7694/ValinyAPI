using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class T_Documento
    {
        [Key]
        [MaxLength(1)]
        public int ID_Documento {  get; set; }
        public string Tipo_Documento { get; set; }
    }
}
