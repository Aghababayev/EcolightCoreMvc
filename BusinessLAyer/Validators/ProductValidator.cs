using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName)
               .NotEmpty().WithMessage("Productname can't be blank")
                  .MaximumLength(20).WithMessage("Maximum 20 characters")
                    .MinimumLength(2).WithMessage("Minimum 2 characters");
                      
            RuleFor(x => x.BrandID)
               .NotEmpty().WithMessage("Brand can't be blank");
            RuleFor(x => x.Description)
               .MaximumLength(500).WithMessage("Maximum 500 characters");
            RuleFor(x => x.Lumens)
                .GreaterThan(0).WithMessage("The lumen represents the illumination of light, so it will be more than 0");
            RuleFor(x => x.Watt)
               .GreaterThan(0).WithMessage("It will be more than 0");
            RuleFor(x=>x.Stock)
               .GreaterThan(-1).WithMessage("Negative stock isn't proper our company policy");
        }
      
    }
}
