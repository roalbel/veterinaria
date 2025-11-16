using veterinaria.infretruture.Model;

namespace veterinaria.infretruture.Interfaces
{
    public interface IMascotaRepositorie : IBaserepositorie<MascotaModel>
    {
        Task CreateMascotaAsync(MascotaModel mascota);
        Task<List<MascotaModel>> GetAllMascotasAsync();
        Task<MascotaModel> GetMascotaByIdAsync(int id);
        Task<MascotaModel> UpdateMascotaAsync(int id, MascotaModel mascota);
        Task<MascotaModel> DeleteMascotaAsync(int id);
    }
}
