using System;
using System.Collections.Generic;

namespace Managio_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }

        public virtual ICollection<UserProject> UserProjects { get; set; }


    }
}