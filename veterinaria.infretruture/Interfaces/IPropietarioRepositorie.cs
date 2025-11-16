using veterinaria.infretruture.Model;

namespace veterinaria.infretruture.Interfaces
{
    public interface IPropietarioRepositorie : IBaserepositorie<PropietarioModel>
    {
        Task CreatePropietarioAsync(PropietarioModel propietario);
        Task<List<PropietarioModel>> GetAllPropietariosAsync();
        Task<PropietarioModel> GetPropietarioByIdAsync(int id);
        Task<PropietarioModel> UpdatePropietarioAsync(int id, PropietarioModel propietario);
        Task<PropietarioModel> DeletePropietarioAsync(int id);
    }
}
