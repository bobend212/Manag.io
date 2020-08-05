using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managio_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Managio_API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void AddUser<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void DeleteUser<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.UserProjects).FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(p => p.UserProjects).ToListAsync();
            return users;
        }

        public async Task<bool> SaveChanges()
        {
            //If the result is more than 0 saving to the database is succeeded. Otherwise, not succeeded.
            return await _context.SaveChangesAsync() > 0;
        }
    }
}