using ContaHoueseMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace ContaHoueseMvc.Data
{
    public class ContaDbContext : DbContext
    {
        public ContaDbContext(DbContextOptions<ContaDbContext> options) : base(options)
        {
                
        }
        
        public DbSet<ContaModel> Contas { get; set; }
    }
}
