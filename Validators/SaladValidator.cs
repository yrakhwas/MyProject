using FluentValidation;
using MyProject.DataAccess1.Entities;

namespace MyProject.Validators
{
    public class SaladValidator:AbstractValidator<Salad>
    {
        public SaladValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Price).NotNull().GreaterThanOrEqualTo(0);
        }
    }
}
