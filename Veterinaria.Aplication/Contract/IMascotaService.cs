using Veterinaria.Aplication.DTOS;

namespace Veterinaria.Aplication.Contract
{
    public interface IMascotaService
    {
        Task<MascotaDto> CreateMascotaAsync(MascotaDto mascotaDto);
        Task<List<MascotaDto>> GetAllMascotasAsync();
        Task<MascotaDto> GetMascotaByIdAsync(int id);
        Task<MascotaDto> UpdateMascotaAsync(int id, MascotaDto mascotaDto);
        Task DeleteMascotaAsync(int id);
    }
}
