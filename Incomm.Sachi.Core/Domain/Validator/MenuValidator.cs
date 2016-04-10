using FluentValidation;
using Incomm.Sachi.Core.Client.Data;

namespace Incomm.Sachi.Core.Domain.Validator
{
    public class MenuValidator: AbstractValidator<MenuDto> 
    {
        public MenuValidator()
        {
            //RuleFor(m => m.Category).NotEmpty().WithMessage("Please specify a category.");
            //RuleFor(m => m.DrinkSize).NotEmpty().WithMessage("Please specify a drink size.");
            //RuleFor(m => m.DrinkType).NotEmpty().WithMessage("Please specify a drink type.");
            
        }
    }
}
