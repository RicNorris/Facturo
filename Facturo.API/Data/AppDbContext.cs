using Facturo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Facturo.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
