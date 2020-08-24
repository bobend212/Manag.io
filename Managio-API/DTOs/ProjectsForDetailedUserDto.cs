using System.ComponentModel.DataAnnotations;

namespace Managio_API.DTOs
{
    public class ProjectsForDetailedUserDto
    {
        public int ProjectId { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public bool IsFinished { get; set; }
    }
}