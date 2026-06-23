using Microsoft.EntityFrameworkCore;

namespace TProjectSolution.DataAccess.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}