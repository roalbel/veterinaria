
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using veterinaria.infretruture.Model;

namespace veterinaria.infretruture.Model
{

    public class VacunaModel
    {
        public int VacunaId { get; set; }
        public string NombreVacuna { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Veterinario { get; set; }

       
        public int MascotaId { get; set; }
        public MascotaModel Mascota { get; set; }

        public VacunaModel() { }
    }

}