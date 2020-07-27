using System.ComponentModel.DataAnnotations;

namespace Managio_API.Models
{
    public class UserProject
    {
        [Key]
        public int UserId { get; set; }

        [Key]
        public int ProjectId { get; set; }


        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
    }
}