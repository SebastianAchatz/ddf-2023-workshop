using DDF2023.Onion.Core.DomainModel;

namespace DDF2023.Onion.Core.DomainServices;

public interface IUserRepository
{
    void AddUser(User user);
    
    User? GetUser(string username);
    bool UserExists(string username);
}