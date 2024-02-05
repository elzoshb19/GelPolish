using GelPolishStore.Models.Requests;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace GelPolishStore.Validators
{
    public class TestRequestValidation : AbstractValidator<GetAllGelPolishesByManufactureRequest>
    {

        public TestRequestValidation()
        {
            RuleFor(x => x.ManufactureId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0).WithMessage("> 0");

            RuleFor(x => x.AfterDate)
                .NotEmpty()
                .NotNull();

        }
    }
}