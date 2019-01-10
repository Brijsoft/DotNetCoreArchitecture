using DotNetCore.Validation;
using DotNetCoreArchitecture.CrossCutting.Resources;
using DotNetCoreArchitecture.Model.Models;
using FluentValidation;

namespace DotNetCoreArchitecture.Model.Validators
{
    public sealed class SignedInModelValidator : Validator<SignedInModel>
    {
        public SignedInModelValidator() : base(Texts.AuthenticationInvalid)
        {
            RuleFor(x => x).NotNull();
            RuleFor(x => x.UserId).GreaterThan(0);
        }
    }
}
