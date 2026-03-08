using Microsoft.AspNetCore.Identity;

namespace Shopper.Infrastructure.Identity;

// Extending Entity Framework IdentityUser properties
public class ApplicationUser : IdentityUser
{
    public DateOnly? DateOfBirth { get; set; }
    public string? Country { get; set; }
}
