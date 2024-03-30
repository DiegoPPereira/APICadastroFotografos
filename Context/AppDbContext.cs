using CadastroFotografo.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroFotografo.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Fotografo>? Fotografos { get; set; }

    public DbSet<Visita>? Visitas { get; set; }

}


   
