using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend.Models
{
    public class AppDbContext : DbContext
    {
        // Construtor que aceita opções de configuração
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet para a entidade Veiculo
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
