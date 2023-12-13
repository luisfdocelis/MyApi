using Microsoft.AspNetCore.Identity;

namespace MyApi.Models.Jwt;

public class User : IdentityUser
{
    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;
}