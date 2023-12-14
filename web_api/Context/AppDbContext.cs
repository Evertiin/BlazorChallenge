using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Login> Logins { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
