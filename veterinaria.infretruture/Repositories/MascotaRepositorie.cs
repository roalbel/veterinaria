using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;
using veterinaria.infretruture.Core;

namespace veterinaria.infretruture.Repositories
{
    public class MascotaRepositorie : Baserepositorie<MascotaModel >
    {
        public MascotaRepositorie(VeterinariaContex contex) : base(contex)
        {
        }
    }
}
