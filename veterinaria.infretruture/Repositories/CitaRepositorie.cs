using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;
using veterinaria.infretruture.Core;

namespace veterinaria.infretruture.Repositories
{
    public class CitaRepositorie : Baserepositorie<CitaModel >
    {
        public CitaRepositorie(VeterinariaContex contex) : base(contex)
        {
        }
    }
}
