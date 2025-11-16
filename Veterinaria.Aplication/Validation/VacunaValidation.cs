using FluentValidation;
using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;

public class VacunaValidation : AbstractValidator<VacunaModel>
{
    private readonly VeterinariaContex _context;

    public VacunaValidation(VeterinariaContex context)
    {
        _context = context;

        RuleFor(v => v.NombreVacuna)
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(v => v.FechaAplicacion)
            .NotEmpty()
            .LessThanOrEqualTo(DateTime.Now);

        RuleFor(v => v.Veterinario)
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(v => v.MascotaId)
            .GreaterThan(0)
            .Must(id => _context.Mascotas.Any(m => m.MascotaId == id))
            .WithMessage("La mascota no existe.");
    }
}
