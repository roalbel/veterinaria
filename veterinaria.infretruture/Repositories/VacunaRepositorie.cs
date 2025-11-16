using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;
using veterinaria.infretruture.Core;

namespace veterinaria.infretruture.Repositories
{
    public class VacunaRepositorie : Baserepositorie<VacunaModel >
    {
        public VacunaRepositorie(VeterinariaContex contex) : base(contex)
        {
        }
    }
}
