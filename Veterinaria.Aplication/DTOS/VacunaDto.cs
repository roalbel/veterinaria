namespace Veterinaria.Aplication.DTOS
{
    public class VacunaDto
    {
        public string NombreVacuna { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Veterinario { get; set; }
        public int MascotaId { get; set; }
    }

}
