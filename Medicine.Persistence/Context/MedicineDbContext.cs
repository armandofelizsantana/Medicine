using Microsoft.EntityFrameworkCore;
using Medicine.Domain.Entities;

namespace Medicine.Persistence.Context
{
    public class MedicineDbContext : DbContext
    {
        public MedicineDbContext(DbContextOptions<MedicineDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Disponibilidad> Disponibilidades { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Paciente>().ToTable("Pacientes");
            modelBuilder.Entity<Medico>().ToTable("Medicos");
            modelBuilder.Entity<Cita>().ToTable("Citas");
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Especialidad>().ToTable("Especialidades");
            modelBuilder.Entity<Disponibilidad>().ToTable("Disponibilidades");
            modelBuilder.Entity<Notificacion>().ToTable("Notificaciones");
        }
    }
}