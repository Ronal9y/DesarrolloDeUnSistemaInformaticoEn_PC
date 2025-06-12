using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DesarrolloDeUnSistemaInformaticoEn_PC.Models;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Raza> Razas { get; set; }
    public DbSet<RelacionSize> RelacionSizes { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<SolicitudAdopcion> SolicitudesAdopcion { get; set; }
    public DbSet<EstadoSolicitud> EstadosSolicitud { get; set; }
    public DbSet<HistorialAdopcion> HistorialAdopciones { get; set; }
    public DbSet<SeguimientoMascota> SeguimientosMascotas { get; set; }
    public DbSet<EstadoMascota> EstadosMascota { get; set; }
    public DbSet<Adoptante> Adoptantes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        base.OnModelCreating(modelBuilder);

     
        modelBuilder.Entity<Raza>()
            .HasOne(r => r.Categoria)
            .WithMany(c => c.Razas)
            .HasForeignKey(r => r.CategoriaId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Mascota>()
            .HasOne(m => m.Categoria)
            .WithMany(c => c.Mascotas)
            .HasForeignKey(m => m.CategoriaId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Mascota>()
            .HasOne(m => m.Raza)
            .WithMany()
            .HasForeignKey(m => m.RazaId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Mascota>()
            .HasOne(m => m.RelacionSize)
            .WithMany(rs => rs.Mascotas)
            .HasForeignKey(m => m.RelacionSizeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Mascota>()
            .HasOne(m => m.Estado)
            .WithMany(e => e.Mascotas)
            .HasForeignKey(m => m.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
