using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace tallermecanico.domain.Entityes
{

    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Perro, Gato, etc.
        public string Raza { get; set; }
        public int Edad { get; set; }

        // Relación con Propietario (1 Propietario – N Mascotas)
        public int PropietarioId { get; set; }
        public Propietario Propietario { get; set; }

        // Relación con Vacunas (1 Mascota – N Vacunas)
        public List<Vacuna> Vacunas { get; set; }

        // Relación con Citas (1 Mascota – N Citas)
        public List<Cita> Citas { get; set; }

        public Mascota()
        {
            Vacunas = new List<Vacuna>();
            Citas = new List<Cita>();
        }
    }


}