using DDF2023.Onion.Core.DomainModel;
using DDF2023.PnA.Ports;

namespace DDF2023.Onion.Core.DomainServices;

public class UserManagementService : IUserManagementService
{
    private readonly IUserRepository _userRepository;

    public UserManagementService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public void AddUser(User user)
    {
        if (_userRepository.UserExists(user.Username))
            throw new UserAlreadyExistsException("Username already exists");
        
        _userRepository.AddUser(user);
    }
}