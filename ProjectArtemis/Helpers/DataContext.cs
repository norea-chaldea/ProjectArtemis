using Microsoft.EntityFrameworkCore;
using ProjectArtemis.Entities;

namespace ProjectArtemis.Helpers;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications
        options.UseSqlite(Configuration.GetConnectionString("ProjectArtemisDatabase"));
    }

    public DbSet<User> Users { get; set; }
}