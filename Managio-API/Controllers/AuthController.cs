using System.Threading.Tasks;
using Managio_API.Data;
using Managio_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Managio_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            //validate later

            username = username.ToLower();

            if (await _repo.UserExist(username))
                return BadRequest("Username already exist.");

            var userToCreate = new User
            {
                Username = username
            };

            var createdUser = await _repo.Register(userToCreate, password);

            return StatusCode(201); //fix later
        }
    }
}