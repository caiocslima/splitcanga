using Microsoft.EntityFrameworkCore;
using SplitCanga.Models;

namespace SplitCanga.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}
