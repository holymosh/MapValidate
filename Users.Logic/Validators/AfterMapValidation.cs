using AutoMapper;
using FluentValidation;

namespace Users.Logic.Validators
{
    public class AfterMapValidation<TSource, TDestination> : IMappingAction<TSource, TDestination>
    {
        private readonly IValidator<TDestination> _validator;

        public AfterMapValidation(IValidator<TDestination> validator)
        {
            _validator = validator;
        }

        public void Process(TSource source, TDestination destination, ResolutionContext context)
        {
            var validationResult = _validator.Validate(destination);
            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);
        }
    }
}