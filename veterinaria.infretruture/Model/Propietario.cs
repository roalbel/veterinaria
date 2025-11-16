using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace veterinaria.infretruture.Model
{

    public class PropietarioModel
    {
        [Key]
        public int PropietatioId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

 
        public List<MascotaModel> Mascotas { get; set; }
        public List<CitaModel> Citas { get; set; }


        public PropietarioModel()
        {
            
        }
    }

}
