using Microsoft.EntityFrameworkCore;

namespace PersonalWebsite.API;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
    {
        
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}