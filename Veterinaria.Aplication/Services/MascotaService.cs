using Veterinaria.Aplication.DTOS;
using Mapster;
using veterinaria.infretruture.Interfaces;
using veterinaria.infretruture.Model;
using Veterinaria.Aplication.Contract;

namespace Veterinaria.Aplication.Services
{
    public class MascotaService : IMascotaService
    {
        private readonly IMascotaRepositorie _mascota;

        public MascotaService(IMascotaRepositorie mascota)
        {
            _mascota = mascota;
        }

        public async Task<MascotaDto> CreateMascotaAsync(MascotaDto mascotaDto)
        {
            var mascota = mascotaDto.Adapt<MascotaModel>();
            await _mascota.CreateMascotaAsync(mascota);
            return mascotaDto;
        }

        public async Task<List<MascotaDto>> GetAllMascotasAsync()
        {
            var mascotas = await _mascota.GetAllMascotasAsync();
            return mascotas.Adapt<List<MascotaDto>>();
        }

        public async Task<MascotaDto> GetMascotaByIdAsync(int id)
        {
            var mascota = await _mascota.GetMascotaByIdAsync(id);
            return mascota.Adapt<MascotaDto>();
        }

        public async Task<MascotaDto> UpdateMascotaAsync(int id, MascotaDto mascotaDto)
        {
            var mascota = mascotaDto.Adapt<MascotaModel>();
            await _mascota.UpdateMascotaAsync(id, mascota);
            return mascotaDto;
        }

        public async Task DeleteMascotaAsync(int id)
        {
            await _mascota.DeleteMascotaAsync(id);
        }
    }
}
