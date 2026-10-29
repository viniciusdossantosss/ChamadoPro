using Microsoft.EntityFrameworkCore;
using ChamadoPro.Api.Entidades;

namespace ChamadoPro.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Chamado> Chamados { get; set; }
    public DbSet<Comentario> Comentarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
}
