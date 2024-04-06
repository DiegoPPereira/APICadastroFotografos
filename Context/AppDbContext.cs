using CadastroFotografo.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroFotografo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Fotografo>? Fotografos { get; set; }

        public DbSet<Visita>? Visitas { get; set; }
    }
}
