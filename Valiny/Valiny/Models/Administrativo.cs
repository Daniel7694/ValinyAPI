using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valiny.Models
{
    public class Administrativo
    {
        public int AdministrativoId { get; set; }
        public string P_Nombre { get; set; }
        public string S_Nombre { get; set; }
        public string P_Apellido { get; set; }
        public string S_Apellido { get; set; }
        public string T_Documento {  get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual ICollection<AdministrativoRol> AdministrativoRol { get; set; }
        public virtual ICollection<AdministrativoClave> AdministrativoClave { get; set; }
        public virtual ICollection<Registro> Registro { get; set; }
    }
}
