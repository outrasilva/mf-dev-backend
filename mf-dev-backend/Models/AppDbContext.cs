using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
