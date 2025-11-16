using Veterinaria.Aplication.DTOS;
using Mapster;
using veterinaria.infretruture.Interfaces;
using veterinaria.infretruture.Model;
using Veterinaria.Aplication.Contract;

namespace Veterinaria.Aplication.Services
{
    public class VacunaService : IVacunaService
    {
        private readonly IVacunaRepositorie _vacuna;

        public VacunaService(IVacunaRepositorie vacuna)
        {
            _vacuna = vacuna;
        }

        public async Task<VacunaDto> CreateVacunaAsync(VacunaDto vacunaDto)
        {
            var vacuna = vacunaDto.Adapt<VacunaModel>();
            await _vacuna.CreateVacunaAsync(vacuna);
            return vacunaDto;
        }

        public async Task<List<VacunaDto>> GetAllVacunasAsync()
        {
            var vacunas = await _vacuna.GetAllVacunasAsync();
            return vacunas.Adapt<List<VacunaDto>>();
        }

        public async Task<VacunaDto> GetVacunaByIdAsync(int id)
        {
            var vacuna = await _vacuna.GetVacunaByIdAsync(id);
            return vacuna.Adapt<VacunaDto>();
        }

        public async Task<VacunaDto> UpdateVacunaAsync(int id, VacunaDto vacunaDto)
        {
            var vacuna = vacunaDto.Adapt<VacunaModel>();
            await _vacuna.UpdateVacunaAsync(id, vacuna);
            return vacunaDto;
        }

        public async Task DeleteVacunaAsync(int id)
        {
            await _vacuna.DeleteVacunaAsync(id);
        }
    }
}
