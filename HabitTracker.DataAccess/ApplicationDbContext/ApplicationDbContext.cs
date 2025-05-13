using Microsoft.EntityFrameworkCore;

namespace HabitTracker.DataAccess.ApplicationDbContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
}