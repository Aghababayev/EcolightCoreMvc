using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Validators
{
    public class DistributorValidator : AbstractValidator<Distributor>
    {
        public DistributorValidator()
        {
            RuleFor(x=>x.Dname).NotNull().WithMessage("Can't be null");
            RuleFor(x => x.Dmail).EmailAddress().WithMessage("Enter mail adress (Example:abc@gmail.com) ")
                .NotNull().WithMessage("Email address is NECESSARY information");
        }
    }
}
