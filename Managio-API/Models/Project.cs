using System;
using System.Collections.Generic;

namespace Managio_API.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFinished { get; set; }
        public virtual ICollection<UserProject> UserProjects { get; set; }
    }
}