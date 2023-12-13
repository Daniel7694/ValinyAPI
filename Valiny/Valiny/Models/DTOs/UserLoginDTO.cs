
using System.ComponentModel.DataAnnotations;
namespace Valiny.Models.DTOs
{
    public class UserLoginDTO
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage ="El Documento es obligatorio")]
        public String UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "La contraseña es obligatorio")]
        public String Password { get; set; }
    }
}
