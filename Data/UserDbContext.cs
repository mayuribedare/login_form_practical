using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AuthSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace AuthSystem.Data
{
    public class UserDbContext : IdentityDbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserModel> User { get; set; }
    }
}
