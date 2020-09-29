using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Managio_API.Data;
using Managio_API.DTOs;
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
        private readonly IProjectRepository _repo;
        private readonly IMapper _mapper;
        public ProjectsController(IProjectRepository repo, IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _repo = repo;

            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var projects = await _repo.GetProjects();

            var projectsToReturn = _mapper.Map<IEnumerable<ProjectsForListDto>>(projects);

            return Ok(projectsToReturn);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id)
        {
            var project = await _repo.GetProject(id);

            var projectToReturn = _mapper.Map<ProjectForDetailedDto>(project);

            return Ok(projectToReturn);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<Project> AddProject([FromBody] Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();

            return project;
        }

        // [AllowAnonymous]
        // [HttpPut("{id}")]
        // public async Task<IActionResult> UpdateProject(int id, [FromBody] Project projectToUpdate)
        // {
        //     var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);

        //     if (project != null)
        //     {
        //         project.Number = projectToUpdate.Number;
        //         project.Name = projectToUpdate.Name;
        //         project.DateAdded = projectToUpdate.DateAdded;
        //         project.IsFinished = projectToUpdate.IsFinished;
        //     }

        //     await _context.SaveChangesAsync();

        //     return Content("Updated successfully");
        // }
    }
}