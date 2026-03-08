using MediatR;

namespace Shopper.Application.Users.Commands.UpdateUserDetails;

public record UpdateUserDetailsCommand : IRequest
{
    public DateOnly? DateOfBirth { get; set; }
    public string? Country { get; set; }
}
