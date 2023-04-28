// See https://aka.ms/new-console-template for more information

using DDF2023.PnA.Adapters.FileStorage;
using DDF2023.PnA.ApplicationDomain.Entities;
using DDF2023.PnA.ApplicationDomain.Services;
using DDF2023.PnA.Ports;

IUserManagementService userManagementService = 
    new UserManagementService(new UserFileRepository("/Users/sebastian/Desktop/UserData"));

var newUser = new User()
{
    Username = "jdoe",
    Firstname = "John",
    Lastname = "Doe",
    DateOfBirth = new DateOnly(1980, 1, 1)
};

userManagementService.AddUser(newUser);

Console.WriteLine("Hello, World!");