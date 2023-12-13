using System.ComponentModel.DataAnnotations;

namespace Valiny.Models.DTOs
{
    public class UserRegisterDTO
    {
        [Required(ErrorMessage = "El Documento de usuario es requerido")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "El password es requerido")]
        public string Password { get; set; }
        public List<string> Roles { get; set; } // Changed to List for multiple roles
    }
}
