using Microsoft.EntityFrameworkCore;

namespace TaskManager.Web.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; } // Certifique-se de que isso está presente
    }
}

