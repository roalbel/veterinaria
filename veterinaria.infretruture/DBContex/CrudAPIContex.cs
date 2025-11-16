using Microsoft.EntityFrameworkCore;
using veterinaria.infretruture.Model;
namespace veterinaria.infretruture.DBContex
{
    public class VeterinariaContex: DbContext
    {
        public VeterinariaContex(DbContextOptions<VeterinariaContex> options) : base(options)
        {
        }
        public DbSet<CitaModel> Citas { get; set; }
        public DbSet<MascotaModel> Mascotas { get; set; }
        public DbSet<VacunaModel> Vacunas { get; set; }
        public DbSet<PropietarioModel> Propietarios { get; set; }

        public VeterinariaContex() { }
    }
} 
