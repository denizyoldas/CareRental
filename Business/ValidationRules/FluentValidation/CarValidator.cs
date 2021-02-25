using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(p => p.ModelYear).Must(checkYear).WithMessage("Ürünler A harfi ile başlamalı");
        }

        private bool checkYear(DateTime arg)
        {
            return true;
        }
    }
}
