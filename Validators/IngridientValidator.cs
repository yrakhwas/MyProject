using FluentValidation;
using MyProject.DataAccess1.Entities;

namespace MyProject.Validators
{
    public class IngridientValidator: AbstractValidator<Ingridient>
    {
        public IngridientValidator()
        {
            RuleFor(x=>x.Id).NotNull().NotEmpty();
            RuleFor(x=>x.Name).NotNull().NotEmpty();
            RuleFor(x=>x.Price).NotNull().GreaterThanOrEqualTo(0);
        }
    }
}
