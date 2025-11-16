using System;
using System.ComponentModel.DataAnnotations;
namespace tallermecanico.domain.Entityes 
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; } 
    }

}