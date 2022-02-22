using FluentValidation;
using Users.Domain.Entities;

namespace Users.Logic.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name).NotEmpty().NotNull().WithMessage("является обязательным");
            RuleFor(u => u.Surname).NotEmpty().NotNull();
            RuleFor(u => u.Phone).NotEmpty().NotNull();
            RuleFor(u => u.Email).NotEmpty().NotNull();
        }
    }
}