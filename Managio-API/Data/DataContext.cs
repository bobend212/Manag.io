using Microsoft.EntityFrameworkCore;

namespace Managio_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        
        
    }
}