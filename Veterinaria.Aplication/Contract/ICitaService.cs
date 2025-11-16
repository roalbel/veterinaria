
using Veterinaria.Aplication.DTOS;
namespace Veterinaria.Aplication.Contract
{
    public interface ICitaService
    {
        Task<CitaDto> CreatecitaAsync(CitaDto CitaDto);
        Task DeletecitaAsync(int id);
        Task<List<CitaDto>> GetAllcitasAsync();
        Task<CitaDto> GetcitaByIdAsync(int id);
        Task<CitaDto> UpdatecitaAsync(int id, CitaDto CitaDto);
    }
}