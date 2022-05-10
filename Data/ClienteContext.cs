using Cadastro.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cliente = modelBuilder.Entity<Cliente>();
            cliente.ToTable("Clientes");
            cliente.HasKey(x => x.Id);
        }
    }
}
