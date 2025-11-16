using veterinaria.infretruture.Model;

namespace veterinaria.infretruture.Interfaces
{
    public interface ICitaRepositorie : IBaserepositorie<CitaModel >
    {
        Task CreatecitaAsync(CitaModel cita);
        Task<List<CitaModel>> GetAllcitasAsync();
        Task<CitaModel> GetcitaByIdAsync(int id);
        Task<CitaModel> UpdatecitaAsync(int id, CitaModel cita);
        Task<CitaModel> DeletecitaAsync(int id);
    }
}
