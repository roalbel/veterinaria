using Microsoft.EntityFrameworkCore;
using veterinaria.infretruture.Model;

namespace veterinaria.infretruture.DBContex
{
    public class VeterinariaContex : DbContext
    {
        public VeterinariaContex(DbContextOptions<VeterinariaContex> options) : base(options)
        {
        }

        public DbSet<CitaModel> Citas { get; set; }
        public DbSet<MascotaModel> Mascotas { get; set; }
        public DbSet<VacunaModel> Vacunas { get; set; }
        public DbSet<PropietarioModel> Propietarios { get; set; }

        public VeterinariaContex() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación Mascota -> Propietario con cascade
            modelBuilder.Entity<MascotaModel>()
                .HasOne(m => m.Propietario)
                .WithMany(p => p.Mascotas)
                .HasForeignKey(m => m.PropietarioId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relación Cita -> Mascota con cascade
            modelBuilder.Entity<CitaModel>()
                .HasOne(c => c.Mascota)
                .WithMany(m => m.Citas)
                .HasForeignKey(c => c.MascotaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relación Cita -> Propietario SIN cascade (para evitar multiple cascade paths)
            modelBuilder.Entity<CitaModel>()
                .HasOne(c => c.Propietario)
                .WithMany(p => p.Citas)
                .HasForeignKey(c => c.PropietarioId)
                .OnDelete(DeleteBehavior.Restrict); // 🔹 Importante
        }
    }
}
  