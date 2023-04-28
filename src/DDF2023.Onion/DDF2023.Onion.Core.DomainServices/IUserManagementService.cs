using DDF2023.Onion.Core.DomainModel;

namespace DDF2023.Onion.Core.DomainServices;

public interface IUserManagementService
{
    void AddUser(User user);
    //UserAddResult AddUser2(User user);
}

public class UserAddResult
{
    public bool Failed { get; set; }
    public UserAddedFailedReason Type { get; set; }
    public User CreatedeUser { get; set; }
}

public enum UserAddedFailedReason
{
    UsernameAlreadyExists,
    TechnicalError
}