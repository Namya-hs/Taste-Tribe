using Microsoft.EntityFrameworkCore;
using Shared;

namespace Databases.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            
        }

        public DbSet<UserDto> User { get; set; }
    }
}
