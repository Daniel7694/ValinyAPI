using System.ComponentModel.DataAnnotations;

namespace Valiny.Models
{
    public class TiposRegistro
    {
        [MaxLength(10)]
        public int TiposRegistroId { get; set; }
        [MaxLength(20)]
        public string NombreRegistro { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Registro> Registro { get; set; }
    }
}
