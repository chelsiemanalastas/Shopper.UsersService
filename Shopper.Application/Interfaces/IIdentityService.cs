namespace Shopper.Application.Interfaces;

public interface IIdentityService
{
    Task UpdateUserDetailsAsync(string userId, string? country, DateOnly? dateOfBirth, CancellationToken cancellationToken = default);
}
