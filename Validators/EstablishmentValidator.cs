using FluentValidation;
using MyProject.DataAccess1.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Validators
{
    public class EstablishmentValidator: AbstractValidator<Establishment>
    {
        public EstablishmentValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().Length(0,40);
            RuleFor(x => x.Adress).NotNull().Length(0, 40);
            RuleFor(x => x.pizzas).Null();
            RuleFor(x => x.sushis).Null();
            RuleFor(x => x.salads).Null();
        }
    }
}
