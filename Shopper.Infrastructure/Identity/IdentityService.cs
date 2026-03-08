using Microsoft.AspNetCore.Identity;
using Shopper.Application.Exceptions;
using Shopper.Application.Interfaces;

namespace Shopper.Infrastructure.Identity;

public class IdentityService(
        UserManager<ApplicationUser> userManager
    ) : IIdentityService
{
    public async Task UpdateUserDetailsAsync(string userId, string? country, DateOnly? dateOfBirth, CancellationToken cancellationToken = default)
    {
        var user = await userManager.FindByIdAsync(userId);

        if (user is null)
            throw new NotFoundException(nameof(ApplicationUser), nameof(userId), userId);

        user.Country = country;
        user.DateOfBirth = dateOfBirth;

        var result = await userManager.UpdateAsync(user);

        if (!result.Succeeded)
            throw new InvalidOperationException(result.Errors.First().Description);
    }
}
