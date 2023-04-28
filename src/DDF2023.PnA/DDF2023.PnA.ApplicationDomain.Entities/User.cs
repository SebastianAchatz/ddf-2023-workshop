namespace DDF2023.PnA.ApplicationDomain.Entities;

public class User
{
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public required string Username { get; set; }
    public DateOnly? DateOfBirth { get; set; }
}