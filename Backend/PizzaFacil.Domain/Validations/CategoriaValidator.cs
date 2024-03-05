using FluentValidation;
using PizzaFacil.Domain.Models;

namespace PizzaFacil.Domain.Validations
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome da categoria é obrigatório")
                .Length(4, 50).WithMessage("O nome da categoria deve ter entre 4 e 50 caracteres");
        }
    }
}
