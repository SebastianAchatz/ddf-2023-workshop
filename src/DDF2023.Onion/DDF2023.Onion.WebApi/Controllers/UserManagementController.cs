using DDF2023.Onion.Core.DomainModel;
using DDF2023.Onion.Core.DomainServices;
using DDF2023.Onion.WebApi.PublicModels;
using Microsoft.AspNetCore.Mvc;

namespace DDF2023.Onion.WebApi.Controllers;

[ApiController]
public class UserManagementController : ControllerBase
{
    private readonly ILogger<UserManagementController> _logger;
    private readonly IUserManagementService _userManagementService;

    public UserManagementController(ILogger<UserManagementController> logger,
        IUserManagementService userManagementService)
    {
        _logger = logger;
        _userManagementService = userManagementService;
    }
    
    [HttpPost]
    [Route("/api/v1/users")]
    public IActionResult AddUser([FromBody] UserModel? userModel)
    {
        if(userModel is null)
            return new BadRequestResult();
        
        if(string.IsNullOrEmpty(userModel.Username))
            return new BadRequestResult();
        
        var user = new User()
        {
            Firstname = userModel.Firstname,
            Lastname = userModel.Lastname,
            Username = userModel.Username,
        };

        try
        {
            _userManagementService.AddUser(user);
        }
        catch (UserAlreadyExistsException e)
        {
            return new ConflictObjectResult(e.Message);
        }
        
        return Ok();
    }
}