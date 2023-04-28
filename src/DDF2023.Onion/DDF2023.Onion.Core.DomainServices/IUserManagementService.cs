using DDF2023.Onion.Core.DomainModel;

namespace DDF2023.PnA.Ports;

public interface IUserManagementService
{
    void AddUser(User user);
}