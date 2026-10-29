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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chamado>(chamado =>
        {
            chamado.Property(c => c.Titulo).HasMaxLength(200);
            chamado.Property(c => c.Descricao).HasMaxLength(4000);

            chamado.HasOne(c => c.Cliente)
                .WithMany()
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Cliente>(cliente =>
        {
            cliente.Property(c => c.Nome).HasMaxLength(100);
            cliente.Property(c => c.Email).HasMaxLength(254);
        });

        modelBuilder.Entity<Comentario>(comentario =>
        {
            comentario.Property(c => c.Texto).HasMaxLength(2000);
        });
    }
}
