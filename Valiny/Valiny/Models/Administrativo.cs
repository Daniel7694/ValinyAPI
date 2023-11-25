using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valiny.Models
{
    public class Administrativo
    {
        [Required]
        [Key]
        [MaxLength(15)]
        public int ID_Admin { get; set; }

        [ForeignKey("ID_Genero")]
        public Genero IdGenero { get; set; }

        [ForeignKey("ID_Rol")]
        public Rol IdRol { get; set; }

        [ForeignKey("ID_Clave")]
        public Clave IdClave { get; set; }

        [ForeignKey("ID_Documento")]
        public T_Documento IdDocumento { get; set; }
        [Required]
        [MaxLength(20)]
        public string P_Nombre { get; set; }
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
