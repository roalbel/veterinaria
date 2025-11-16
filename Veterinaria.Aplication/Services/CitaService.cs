using Veterinaria.Aplication.DTOS; 
using Mapster;
using veterinaria.infretruture.Interfaces;
using veterinaria.infretruture.Model;
using Veterinaria.Aplication.Contract;


namespace Veterinaria.Aplication.Services
{
    public class CitaService : ICitaService
    {
        private readonly ICitaRepositorie _cita;

        public CitaService(ICitaRepositorie cita)
        {
            _cita = cita;
        }


        public async Task<CitaDto> CreatecitaAsync(CitaDto  CitaDto)
        {
            var cita = CitaDto.Adapt<CitaModel>();
            await _cita.CreatecitaAsync(cita);
            return CitaDto;
        }


        public async Task<List<CitaDto>> GetAllcitasAsync()
        {
            var citas = await _cita.GetAllcitasAsync();
            return citas.Adapt<List<CitaDto>>();
        }


        public async Task<CitaDto> GetcitaByIdAsync(int id)
        {
            var cita = await _cita.GetcitaByIdAsync(id);
            return cita.Adapt<CitaDto>();
        }


        public async Task<CitaDto> UpdatecitaAsync(int id, CitaDto CitaDto)
        {
            var cita = CitaDto.Adapt<CitaModel>();
            await _cita.UpdatecitaAsync(id, cita);
            return CitaDto;
        }


        public async Task DeletecitaAsync(int id)
        {
            await _cita.DeletecitaAsync(id);
        }

        public CitaService() { }
    }
}
