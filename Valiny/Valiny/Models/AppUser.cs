using Microsoft.AspNetCore.Identity;

namespace Valiny.Models
{
    public class AppUser : IdentityUser 
    {
        public int Documento { get; set; }
        public string Contrasenia { get; set; }
    }
}
