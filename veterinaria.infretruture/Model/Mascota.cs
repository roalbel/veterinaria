using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace veterinaria.infretruture.Model
{

    public class MascotaModel
    {
        [Key]
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } 
        public string Raza { get; set; }
        public int Edad { get; set; }

        
        public int PropietarioId { get; set; }
        public PropietarioModel Propietario { get; set; }

        
        public List<VacunaModel > Vacunas { get; set; }

        
        public List<CitaModel> Citas { get; set; }

        public MascotaModel()
        {
            
        }
    }


}