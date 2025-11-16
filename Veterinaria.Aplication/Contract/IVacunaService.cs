using Veterinaria.Aplication.DTOS;

namespace Veterinaria.Aplication.Contract
{
    public interface IVacunaService
    {
        Task<VacunaDto> CreateVacunaAsync(VacunaDto vacunaDto);
        Task<List<VacunaDto>> GetAllVacunasAsync();
        Task<VacunaDto> GetVacunaByIdAsync(int id);
        Task<VacunaDto> UpdateVacunaAsync(int id, VacunaDto vacunaDto);
        Task DeleteVacunaAsync(int id);
    }
}
