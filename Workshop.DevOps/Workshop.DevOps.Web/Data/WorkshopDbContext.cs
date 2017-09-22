using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Workshop.DevOps.Web.Models
{
    public class WorkshopDbContext : DbContext
    {
        public WorkshopDbContext (DbContextOptions<WorkshopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Workshop.DevOps.Web.Models.Item> Item { get; set; }
    }
}
