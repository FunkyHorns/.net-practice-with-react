using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Practice.Persistence
{
    public class AppDBContext(DbContextOptions options): DbContext(options)
    {
        public required DbSet<Activity> Activities { get; set; }
    }
}
