using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Validators
{
   public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.BrandName).MinimumLength(3).WithMessage("Minimum 2 characters").MaximumLength(10).WithMessage("Maximum 10 characters").NotEmpty().WithMessage("Please enter Brand ").NotNull().WithMessage("Not null");
        }
    }
}
