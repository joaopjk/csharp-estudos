using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using MyRecipeBook.Exceptions.Base;

namespace MyRecipeBook.Application.UseCases.User;

public class RegisterUserUseCase
{
    public ResponseRegisteredUser Execute(RequestRegisterUser request)
    {
        Validate(request);
        return new ResponseRegisteredUser();
    }

    private static void Validate(RequestRegisterUser request)
    {
        var validator = new RegisterUserValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
            throw new ErrorOnValidationException(result.Errors.Select(x => x.ErrorMessage).ToList());
    }
}