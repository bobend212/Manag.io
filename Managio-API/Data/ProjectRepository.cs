using System.Collections.Generic;
using System.Threading.Tasks;
using Managio_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Managio_API.Data
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DataContext _context;
        public ProjectRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Project> GetProject(int id)
        {
            var project = await _context.Projects.Include(p => p.UserProjects).ThenInclude(c => c.User).FirstOrDefaultAsync(x => x.Id == id);
            return project;
        }

        public async Task<IEnumerable<Project>> GetProjects()
        {
            var projects = await _context.Projects.Include(p => p.UserProjects).ToListAsync();
            return projects;
        }
    }
}