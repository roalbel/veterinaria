using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tallermecanico.domain.Entityes
{

    public class Propietario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // Relación 1 Propietario – N Mascotas
        public List<Mascota> Mascotas { get; set; }

        public Propietario()
        {
            Mascotas = new List<Mascota>();
        }
    }

}
