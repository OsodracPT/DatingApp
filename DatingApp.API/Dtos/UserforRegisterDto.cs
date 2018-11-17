using System;
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
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }

        public UserforRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }

    }
}