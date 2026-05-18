using CognivexAI.Models;
using Microsoft.EntityFrameworkCore;

namespace CognivexAI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}