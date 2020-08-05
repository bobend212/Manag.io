using System.Collections.Generic;
using System.Threading.Tasks;
using Managio_API.Models;

namespace Managio_API.Data
{
    public interface IUserRepository
    {
        void AddUser<T>(T entity) where T : class;
        void DeleteUser<T>(T entity) where T : class;
        Task<bool> SaveChanges();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}