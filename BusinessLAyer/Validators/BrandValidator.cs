using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation;
using System.Linq;

namespace BusinessLAyer.Validators
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.BrandName).NotNull().WithMessage("Please insert brand name");
            RuleFor(x => x.BrandName).MinimumLength(3).WithMessage("Minimum 2 characters").MaximumLength(10).WithMessage("Maximum 10 characters").Must(UniqueName).WithMessage("Name already exist");

        }
        private bool UniqueName(string p)
        {
            if (p != null)
            {
                using var c = new Context();

                var brand = c.Brands.Where(x => x.BrandName.ToLower() == p.ToLower()).SingleOrDefault();

                if (brand == null) return true;
            }



            return false;

        }
    }
}
