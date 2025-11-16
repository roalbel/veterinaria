using FluentValidation;
using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;

public class MascotaValidation : AbstractValidator<MascotaModel>
{
    private readonly VeterinariaContex _context;

    public MascotaValidation(VeterinariaContex context)
    {
        _context = context;

        RuleFor(m => m.Nombre)
            .NotEmpty()
            .MaximumLength(150);

        RuleFor(m => m.Tipo)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(m => m.Raza)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(m => m.Edad)
            .GreaterThanOrEqualTo(0);

        RuleFor(m => m.PropietarioId)
            .GreaterThan(0)
            .Must(id => _context.Propietarios.Any(p => p.PropietatioId == id))
            .WithMessage("El propietario no existe.");
    }
}
