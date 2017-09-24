using Microsoft.EntityFrameworkCore;
using Workshop.DevOps.Source.Web.Models;

namespace Workshop.DevOps.Source.Web.Data
{
    public class WorkshopDbContext : DbContext
    {
        public WorkshopDbContext (DbContextOptions<WorkshopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
    }
}
