using Veterinaria.Aplication.DTOS;
using Mapster;
using veterinaria.infretruture.Interfaces;
using veterinaria.infretruture.Model;
using Veterinaria.Aplication.Contract;

namespace Veterinaria.Aplication.Services
{
    public class PropietarioService : IPropietarioService
    {
        private readonly IPropietarioRepositorie _propietario;

        public PropietarioService(IPropietarioRepositorie propietario)
        {
            _propietario = propietario;
        }

        public async Task<PropietarioDto> CreatePropietarioAsync(PropietarioDto propietarioDto)
        {
            var propietario = propietarioDto.Adapt<PropietarioModel>();
            await _propietario.CreatePropietarioAsync(propietario);
            return propietarioDto;
        }

        public async Task<List<PropietarioDto>> GetAllPropietariosAsync()
        {
            var propietarios = await _propietario.GetAllPropietariosAsync();
            return propietarios.Adapt<List<PropietarioDto>>();
        }

        public async Task<PropietarioDto> GetPropietarioByIdAsync(int id)
        {
            var propietario = await _propietario.GetPropietarioByIdAsync(id);
            return propietario.Adapt<PropietarioDto>();
        }

        public async Task<PropietarioDto> UpdatePropietarioAsync(int id, PropietarioDto propietarioDto)
        {
            var propietario = propietarioDto.Adapt<PropietarioModel>();
            await _propietario.UpdatePropietarioAsync(id, propietario);
            return propietarioDto;
        }

        public async Task DeletePropietarioAsync(int id)
        {
            await _propietario.DeletePropietarioAsync(id);
        }
    }
}
