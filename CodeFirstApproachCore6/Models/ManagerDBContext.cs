using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproachCore6.Models
{
    public class ManagerDBContext : DbContext
    {
        public ManagerDBContext(DbContextOptions<ManagerDBContext> options) : base(options)
        { }
        public DbSet<ManagerModel> Managers { get; set; }  
    }
}
   