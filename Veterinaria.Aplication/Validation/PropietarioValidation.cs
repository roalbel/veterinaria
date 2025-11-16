using FluentValidation;
using veterinaria.infretruture.Model;

public class PropietarioValidation : AbstractValidator<PropietarioModel>
{
    public PropietarioValidation()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(p => p.Cedula)
            .NotEmpty()
            .Length(11);

        RuleFor(p => p.Telefono)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(p => p.Direccion)
            .NotEmpty()
            .MaximumLength(255);
    }
}
