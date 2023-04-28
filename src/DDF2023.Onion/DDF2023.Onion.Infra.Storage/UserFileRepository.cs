using System.Text.Json;
using DDF2023.Onion.Core.DomainModel;
using DDF2023.Onion.Core.DomainServices;

namespace DDF2023.Onion.Infra.Storage;

public class UserFileRepository : IUserRepository
{
    private readonly string _path;

    public UserFileRepository(string path)
    {
        _path = path;
    }
    
    public void AddUser(User user)
    {
        var userAsJson = JsonSerializer.Serialize(user);
        var fileName = $"{user.Username}.json";
        var fullPath = Path.Combine(_path, fileName);
        File.WriteAllText(fullPath, userAsJson);
    }

    public User? GetUser(string username)
    {
        var fileName = $"{username}.json";
        var fullPath = Path.Combine(_path, fileName);
        if(File.Exists(fullPath) == false)
            return null;
        
        var userAsJson = File.ReadAllText(fullPath);
        var user = JsonSerializer.Deserialize<User>(userAsJson);
        return user;
    }
    
    public bool UserExists(string username)
    {
        var fileName = $"{username}.json";
        var fullPath = Path.Combine(_path, fileName);
        return File.Exists(fullPath);
    }
}