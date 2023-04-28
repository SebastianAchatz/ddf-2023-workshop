using DDF2023.PnA.ApplicationDomain.Entities;

namespace DDF2023.PnA.Ports;

public interface IUserManagementService
{
    void AddUser(User user);
}