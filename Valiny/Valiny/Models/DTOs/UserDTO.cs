namespace Valiny.Models.DTOs
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string Documento { get; set; }
        public List<string> Roles { get; set; }
    }
}
