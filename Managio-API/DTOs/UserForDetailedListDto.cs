using System;
using System.Collections.Generic;
using Managio_API.Models;

namespace Managio_API.DTOs
{
    public class UserForDetailedListDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }

        public virtual ICollection<ProjectsForDetailedUserDto> UserProjects { get; set; }
    }
}