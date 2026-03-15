using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User;

public class RegisterUserUseCase
{
    public ResponseRegisteredUser Execute(RequestRegisterUser request)
    {
        Validate(request);
        return new ResponseRegisteredUser();
    }

    private void Validate(RequestRegisterUser request)
    {
        var validator = new RegisterUserValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            var errors = result.Errors.Select(x => x.ErrorMessage);
        }
    }
}