
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using tallermecanico.domain.Entityes;

namespace tallermecanico.domain.Entityes
{

    public class Vacuna
    {
        public int Id { get; set; }
        public string NombreVacuna { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Veterinario { get; set; }

        // Relación con Mascota
        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }

        public Vacuna() { }
    }

}