using Microsoft.AspNetCore.Identity;

namespace Shopper.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public DateOnly? DateOfBrith { get; set; }
    public string? Country { get; set; }
}
