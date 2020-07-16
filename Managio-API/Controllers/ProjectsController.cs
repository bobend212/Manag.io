using System.Linq;
using System.Threading.Tasks;
using Managio_API.Data;
using Managio_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Managio_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext _context;
        public ProjectsController(DataContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var projects = await _context.Projects.ToListAsync();

            if (projects.Count == 0)
                return Content("Project list is empty.");

            return Ok(projects);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(project);
        }

        [HttpPost]
        public async Task<Project> AddProject([FromBody] Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();

            return project;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(int id, [FromBody] Project projectToUpdate)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);

            if (project != null)
            {
                project.Number = projectToUpdate.Number;
                project.Name = projectToUpdate.Name;
                project.DateAdded = projectToUpdate.DateAdded;
                project.IsFinished = projectToUpdate.IsFinished;
            }

            await _context.SaveChangesAsync();

            return Content("Updated successfully");
        }
    }
}