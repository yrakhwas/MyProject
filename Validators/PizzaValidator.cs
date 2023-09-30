using FluentValidation;
using MyProject.DataAccess1.Entities;

namespace MyProject.Validators
{
    public class PizzaValidator: AbstractValidator<Pizza>
    {
        public PizzaValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x=>x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Price).NotNull().GreaterThanOrEqualTo(0);   
        }
    }
}
