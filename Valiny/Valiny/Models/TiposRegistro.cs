namespace Valiny.Models
{
    public class TiposRegistro
    {
        public int TiposRegistroId { get; set; }
        public string NombreRegistro { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Registro> Registro { get; set; }
    }
}
