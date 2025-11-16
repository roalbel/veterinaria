using veterinaria.infretruture.Model;

namespace veterinaria.infretruture.Interfaces
{
    public interface IVacunaRepositorie : IBaserepositorie<VacunaModel>
    {
        Task CreateVacunaAsync(VacunaModel vacuna);
        Task<List<VacunaModel>> GetAllVacunasAsync();
        Task<VacunaModel> GetVacunaByIdAsync(int id);
        Task<VacunaModel> UpdateVacunaAsync(int id, VacunaModel vacuna);
        Task<VacunaModel> DeleteVacunaAsync(int id);
    }
}
