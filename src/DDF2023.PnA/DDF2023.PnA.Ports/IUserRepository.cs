using DDF2023.PnA.ApplicationDomain.Entities;

namespace DDF2023.PnA.Ports;

public interface IUserRepository
{
    void AddUser(User user);
    
    User? GetUser(string username);
    bool UserExists(string username);
}