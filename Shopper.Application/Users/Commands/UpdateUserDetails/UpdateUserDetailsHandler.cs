using MediatR;
using Shopper.Application.Interfaces;

namespace Shopper.Application.Users.Commands.UpdateUserDetails;

public class UpdateUserDetailsHandler<TUser>(
        IUserContext userContext,
        IIdentityService identityService
    ) : IRequestHandler<UpdateUserDetailsCommand>
{
    public async Task Handle(UpdateUserDetailsCommand request, CancellationToken cancellationToken)
    {
        var user = userContext.GetCurrentUser();

        await identityService.UpdateUserDetailsAsync(
            user!.Id,
            request.Country,
            request.DateOfBirth,
            cancellationToken);
    }
}