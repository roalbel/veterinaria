using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Aplication.DTOS
{
    public class MascotaDto
    {
      
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public int PropietarioId { get; set; }
    }

}
