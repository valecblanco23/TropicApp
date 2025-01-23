using ExperienceSync.Areas.Identity.Data;
using ExperienceSync.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExperienceSync.Data;

public class ExperienceSyncContext : IdentityDbContext<ExperienceSyncUser>
{
    public ExperienceSyncContext(DbContextOptions<ExperienceSyncContext> options)
        : base(options)
    {
    }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    
    public DbSet<Local> Locales { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Tarea> Tareas { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
