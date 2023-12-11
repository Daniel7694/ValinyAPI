using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valiny.Models
{
    public class Administrativo
    {
        [MaxLength (10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdministrativoId { get; set; }
        [MaxLength(10)]
        public string P_Nombre { get; set; }
        [MaxLength(10)]
        public string S_Nombre { get; set; }
        [MaxLength(10)]
        public string T_Nombre { get; set; } = string.Empty;
        [MaxLength(10)]
        public string P_Apellido { get; set; }
        [MaxLength(10)]
        public string S_Apellido { get; set; }
        [MaxLength(30)]
        public string T_Documento {  get; set; }

        public virtual ICollection<AdministrativoRol> AdministrativoRol { get; set; }
        public virtual ICollection<AdministrativoClave> AdministrativoClave { get; set; }
        public virtual ICollection<Registro> Registro { get; set; }
    }
}
