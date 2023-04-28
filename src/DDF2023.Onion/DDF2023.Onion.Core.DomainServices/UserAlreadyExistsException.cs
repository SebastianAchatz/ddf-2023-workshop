namespace DDF2023.Onion.Core.DomainServices;

public class UserAlreadyExistsException : Exception
{
    public UserAlreadyExistsException(string usernameAlreadyExists): base(usernameAlreadyExists)
    {
    }
}