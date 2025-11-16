using System;
using System.ComponentModel.DataAnnotations;
namespace veterinaria.infretruture.Model;
    public class CitaModel
    {
    [Key]
        public int CitaId { get; set; }
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; } 
        public int MascotaId { get; set; }
        public MascotaModel Mascota { get; set; }

        public CitaModel() { }
    }

