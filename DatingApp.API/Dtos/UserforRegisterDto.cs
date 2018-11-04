using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserforRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(16, MinimumLength=6, ErrorMessage="You must specify a password between 6 and 16 characters.")]
        public string Password { get; set; }
    }
}