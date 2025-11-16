using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;
using veterinaria.infretruture.Core;

namespace veterinaria.infretruture.Repositories
{
    public class PropietarioRepositorie : Baserepositorie<PropietarioModel >
    {
        public PropietarioRepositorie(VeterinariaContex contex) : base(contex)
        {
        }
    }
}
