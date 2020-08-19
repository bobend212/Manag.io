using System.Collections.Generic;
using System.Threading.Tasks;
using Managio_API.Models;

namespace Managio_API.Data
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetProjects();
        Task<Project> GetProject(int id);
    }
}