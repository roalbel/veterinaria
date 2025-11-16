using FluentValidation;
using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;
using Microsoft.EntityFrameworkCore;

public class CitaValidetion : AbstractValidator<CitaModel>
{
    private readonly VeterinariaContex _context;

    public CitaValidetion(VeterinariaContex contex)
    {
        _context = contex;

        RuleFor(m => m.FechaCita)
            .NotEmpty()
            .GreaterThan(DateTime.Now);

        RuleFor(m => m.Motivo)
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(m => m.Estado)
            .NotEmpty()
            .MaximumLength(50)
            .Must(e => e == "Pendiente" || e == "Completada" || e == "Cancelada");

        RuleFor(m => m.MascotaId)
            .GreaterThan(0)
            .MustAsync(ExistMascota);

        RuleFor(m => m.PropietarioId)
            .GreaterThan(0)
            .MustAsync(ExistPropietario);
    }

    private async Task<bool> ExistMascota(int id, CancellationToken cancel)
        => await _context.Mascotas.AnyAsync(x => x.MascotaId  == id);

    private async Task<bool> ExistPropietario(int id, CancellationToken cancel)
        => await _context.Propietarios.AnyAsync(x => x.PropietatioId == id);
}
