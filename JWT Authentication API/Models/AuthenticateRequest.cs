using System.ComponentModel.DataAnnotations;

namespace JWT_Authentication_API.Models
{
    public class AuthenticateRequest
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
