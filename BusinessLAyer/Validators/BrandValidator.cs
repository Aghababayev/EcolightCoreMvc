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
   public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.BrandName).MinimumLength(3).WithMessage("Minimum 2 characters").MaximumLength(10).WithMessage("Maximum 10 characters").NotEmpty().WithMessage("Please enter Brand ").NotNull().WithMessage("Not null").Must(UniqueName).WithMessage("Name already exist");
          
        }
        private bool UniqueName(string p)
        {
            using Context c = new();
            var brand = c.Brands.Where(x => x.BrandName.ToLower() == p.ToLower()).FirstOrDefault();

            if (brand == null) return true;
          
            return false;
        
        }
    }
}
