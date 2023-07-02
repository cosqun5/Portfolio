using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adi bos kecilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image yeri bos kecilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Image yeri bos kecilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("price yeri bos kecilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Value yeri bos kecilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adi en az 5 herf olmalidi");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adi en cox 100 herf olmalidi");

        }
    }
}
