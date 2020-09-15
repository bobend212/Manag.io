using System;
using System.ComponentModel.DataAnnotations;

namespace Managio_API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "You must specify password between 3 and 8 characters.")]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string Gender { get; set; }

    }
}