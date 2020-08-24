using System;

namespace Managio_API.DTOs
{
    public class ProjectsForListDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public string Status { get; set; }
        public bool IsFinished { get; set; }
    }
}