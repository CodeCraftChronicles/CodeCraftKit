using System.ComponentModel.DataAnnotations;

using Carter;

using FluentValidation;

using Mapster;

using MediatR;

using static Shared.Wrappers.ApiResponse;
namespace WebApi.Features.Security.Identity;

public static class CreateUserAccount
{
    public class Command : IRequest<Result>
    {            
        public string FirstName { get; set; }            
        public string LastName { get; set; }            
        public string Email { get; set; }            
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public bool ActivateUser { get; set; } = false;
        public bool AutoConfirmEmail { get; set; } = false;
    }
    public class Validator : AbstractValidator<Command> { 
    public Validator() {
            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.Email).EmailAddress();
            RuleFor(c=>c.UserName).MinimumLength(6);
            RuleFor(c=>c.Password).NotEmpty().MinimumLength(6);
            RuleFor(c=>c.ConfirmPassword).Equal(c=>c.Password);
        }
    }
    internal sealed class Handler : IRequestHandler<Command, Result> 
    {
        private readonly IValidator<Command> _validator;

        public Handler(IValidator<Command> validator)
        {
            _validator = validator;
        }

        public Task<Result> Handle(Command request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
                return Task.FromResult(Result.Failure (new Error(
                   "CreateUserAccount.Validation",
                   validationResult.ToString())));


        }
    }

}