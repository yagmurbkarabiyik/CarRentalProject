﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(p => p.RentDate).NotEmpty();
            RuleFor(p => p.ReturnDate).NotEmpty();
            RuleFor(p => p.RentDate).GreaterThan(p => p.ReturnDate);
            
        }
    }
}
