using Veterinaria.Aplication.DTOS;

namespace Veterinaria.Aplication.Contract
{
    public interface IPropietarioService
    {
        Task<PropietarioDto> CreatePropietarioAsync(PropietarioDto propietarioDto);
        Task<List<PropietarioDto>> GetAllPropietariosAsync();
        Task<PropietarioDto> GetPropietarioByIdAsync(int id);
        Task<PropietarioDto> UpdatePropietarioAsync(int id, PropietarioDto propietarioDto);
        Task DeletePropietarioAsync(int id);
    }
}
