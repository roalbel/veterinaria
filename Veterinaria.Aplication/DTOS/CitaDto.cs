using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Aplication.DTOS
{
    public class CitaDto

    {
 
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public int MascotaId { get; set; }
    }

}
