namespace Veteriania.API.DTOS
{
    public class CitaDto
    {
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public int MascotaId { get; set; }
    }

}
